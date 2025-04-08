using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaTools.Model;

namespace MetaTools
{
    public class SearchStringInDatabase
    {

        public DataTable SearchDatabase(string connectionString, string searchValue)
        {
            var resultTable = new DataTable();
            resultTable.Columns.AddRange(new[] {
        new DataColumn("TableName"),
        new DataColumn("ColumnName"),
        new DataColumn("FoundValue")
    });

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 获取所有表
                var tables = new List<string>();
                using (var cmd = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) tables.Add(reader.GetString(0));
                }

                foreach (var table in tables)
                {
                    // 获取字段信息
                    var columns = new List<Tuple<string, string>>();
                    using (var cmd = new SqlCommand(
                        "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TableName",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@TableName", table);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                columns.Add(Tuple.Create(
                                    reader.GetString(0),
                                    reader.GetString(1)));
                            }
                        }
                    }

                    // 构建动态查询
                    foreach (var column in columns)
                    {
                        string query = BuildSearchQuery(table, column.Item1, column.Item2);
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@SearchValue", searchValue);
                            try
                            {
                                using (var reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        resultTable.Rows.Add(table, column.Item1, reader);
                                    }
                                }
                            }
                            catch { /* 处理类型转换异常 */ }
                        }
                    }
                }
            }
            return resultTable;
        }

        private string BuildSearchQuery(string table, string column, string dataType)
        {
            var sb = new StringBuilder($"SELECT TOP 1 {column} FROM {table} WHERE ");

            switch (dataType.ToUpper())
            {
                case "VARCHAR":
                case "NVARCHAR":
                    sb.Append($"CHARINDEX(@SearchValue, {column}) > 0");
                    break;
                case "INT":
                case "DECIMAL":
                    sb.Append($"{column} = TRY_CONVERT({dataType}, @SearchValue)");
                    break;
                case "XML":
                    sb.Append($"{column}.exist('//*[text()=sql:variable(\"@SearchValue\")]') = 1");
                    break;
                default:
                    sb.Append($"CHARINDEX(@SearchValue, TRY_CONVERT(NVARCHAR(MAX), {column})) > 0");
                    break;
            }
            return sb.ToString();
        }


        public void SearchLike(string connectionString, string searchValue, DsK3Cloud dsK3Cloud)
        {
            string dynamicSQL = @"
SET NOCOUNT ON; 
DECLARE @sql VARCHAR(1024);DECLARE @table VARCHAR(64);DECLARE @column VARCHAR(64);
CREATE TABLE #t (tablename VARCHAR(64),columnname VARCHAR(64));  
DECLARE TABLES CURSOR FOR SELECT o.name, c.name FROM syscolumns c INNER JOIN sysobjects o ON c.id = o.id WHERE o.type = 'U' AND c.xtype IN (35,99,167,175,231,239,241) ORDER BY o.name, c.name;
OPEN TABLES; 
FETCH NEXT FROM TABLES INTO @table, @column;
WHILE @@FETCH_STATUS = 0 
BEGIN 
SET @sql = 'IF EXISTS(SELECT NULL FROM [' + @table + '] ' 
SET @sql = @sql + 'WHERE CONVERT(NVARCHAR(MAX), [' + @column + ']) LIKE ''%' + @value + '%'') '  
SET @sql = @sql + 'INSERT INTO #t VALUES (''' + @table + ''', '''  
SET @sql = @sql + @column + ''')' 	
EXEC(@sql)
FETCH NEXT FROM TABLES INTO @table, @column 
END 
CLOSE TABLES  
DEALLOCATE TABLES 
SELECT a.*, @value AS FieldValue, ' SELECT * FROM '+a.tablename+' WHERE CONVERT(NVARCHAR(MAX), ['+ a.columnname + ']) LIKE ''%'+@value+ '%'''AS SqlString  FROM #t AS a  
DROP TABLE #t
";//================================================================================

            SqlCmdExecute(connectionString, dynamicSQL, searchValue, dsK3Cloud);
        }

        public void SearchEqual(string connectionString, string searchValue, DsK3Cloud dsK3Cloud)
        {
            string dynamicSQL = @"
SET NOCOUNT ON;DECLARE @sql VARCHAR(1024);DECLARE @table VARCHAR(64);DECLARE @column VARCHAR(64) 
CREATE TABLE #t (tablename VARCHAR(64),columnname VARCHAR(64))  
DECLARE TABLES CURSOR FOR SELECT o.name, c.name FROM syscolumns c INNER JOIN sysobjects o ON c.id = o.id WHERE o.type = 'U' AND c.xtype IN (35,99,167,175,231,239,241) ORDER BY o.name, c.name  
OPEN TABLES 
FETCH NEXT FROM TABLES INTO @table, @column 
WHILE @@FETCH_STATUS = 0 
BEGIN  
SET @sql = 'IF EXISTS(SELECT NULL FROM [' + @table + '] ' 
SET @sql = @sql + 'WHERE CONVERT(NVARCHAR(MAX), [' + @column + ']) = '''+ @value + ''') '  
SET @sql = @sql + 'INSERT INTO #t VALUES (''' + @table + ''', '''  
SET @sql = @sql + @column + ''')'
EXEC(@sql)
FETCH NEXT FROM TABLES INTO @table, @column 
END
CLOSE TABLES 
DEALLOCATE TABLES 
SELECT a.*, @value AS FieldValue, ' SELECT * FROM '+a.tablename+' WHERE  CONVERT(NVARCHAR(MAX), ['+ a.columnname + ']) ='''+@value+ ''''AS SqlString  FROM #t AS a  
DROP TABLE #t 
";//================================================================================
            SqlCmdExecute(connectionString, dynamicSQL, searchValue, dsK3Cloud);
        }


        private void SqlCmdExecute(string connectionString, string sql,string searchValue,DsK3Cloud dsK3Cloud)
        {
            dsK3Cloud.T_Search.Clear(); // 清空数据集
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandTimeout = 0; // 设置超时时间为0，表示不超时
                    // 添加参数（参数化查询防注入）
                    cmd.Parameters.Add("@value", SqlDbType.NVarChar).Value = searchValue;
                    // 执行查询                  
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dsK3Cloud.T_Search);

                }
            }
        }

    }
}
