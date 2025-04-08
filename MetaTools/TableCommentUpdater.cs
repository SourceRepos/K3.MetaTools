using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MetaTools
{

    public class TableCommentUpdater
    {
        private readonly string _connectionString;

        public TableCommentUpdater(string connectionString)
        {
            _connectionString = connectionString;
        }

        // 1. 删除所有用户表注释
        public void DeleteAllTableComments()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 获取所有用户表
                        var tables = GetUserTables(conn, transaction);

                        foreach (var table in tables)
                        {
                            DeleteTableComment(conn, transaction, table.SchemaName, table.TableName);
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void DeleteTableComment()
        {

            using SqlConnection connection = new SqlConnection(_connectionString);
            {
                string sql = @"
DECLARE @sql NVARCHAR(MAX) = '';
SELECT @sql += 
    N'EXEC sp_dropextendedproperty 
        @name = N''MS_Description'', 
        @level0type = N''SCHEMA'', @level0name = ''' + s.name + ''', 
        @level1type = N''TABLE'',  @level1name = ''' + t.name + '''; '
FROM sys.tables t
INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
WHERE t.is_ms_shipped = 0;

EXEC sp_executesql @sql;";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    cmd.CommandTimeout = 0; // 设置超时时间为0，表示不超时
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 2. 批量新增/追加表注释
        public void AddOrUpdateTableComments(Dictionary<string, string> tableComments)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (var kvp in tableComments)
                        {
                            var (schema, tableName) = ParseSchemaAndTableName(kvp.Key);
                            var newComment = kvp.Value;

                            // 获取现有注释
                            var existingComment = GetExistingComment(conn, transaction, schema, tableName);

                            // 合并注释
                            var finalComment = string.IsNullOrEmpty(existingComment)
                                ? newComment
                                : $"{existingComment}{Environment.NewLine}{newComment}";

                            // 更新注释
                            UpdateTableComment(conn, transaction, schema, tableName, finalComment);
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        #region Helper Methods
        // 获取所有用户表（包含架构名）
        private List<(string SchemaName, string TableName)> GetUserTables(SqlConnection conn, SqlTransaction trans)
        {
            var tables = new List<(string, string)>();
            const string sql = @"
            SELECT 
                TABLE_SCHEMA, 
                TABLE_NAME 
            FROM 
                INFORMATION_SCHEMA.TABLES 
            WHERE 
                TABLE_TYPE = 'BASE TABLE' 
                AND TABLE_NAME NOT IN ('sysdiagrams')";

            using (var cmd = new SqlCommand(sql, conn, trans))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    tables.Add((reader.GetString(0), reader.GetString(1)));
                }
            }
            return tables;
        }

        // 删除单个表注释
        private void DeleteTableComment(SqlConnection conn, SqlTransaction trans, string schema, string tableName)
        {
            const string sql = @"
            IF EXISTS (
                SELECT 1 
                FROM sys.extended_properties 
                WHERE major_id = OBJECT_ID(@FullTableName)
                AND minor_id = 0
                AND name = 'MS_Description'
            )
            BEGIN
                EXEC sp_dropextendedproperty 
                    @name = N'MS_Description',
                    @level0type = N'SCHEMA', @level0name = @Schema,
                    @level1type = N'TABLE',  @level1name = @TableName
            END";

            using (var cmd = new SqlCommand(sql, conn, trans))
            {
                cmd.Parameters.AddWithValue("@Schema", schema);
                cmd.Parameters.AddWithValue("@TableName", tableName);
                cmd.Parameters.AddWithValue("@FullTableName", $"{schema}.{tableName}");
                cmd.ExecuteNonQuery();
            }
        }

        // 获取现有表注释
        private string GetExistingComment(SqlConnection conn, SqlTransaction trans, string schema, string tableName)
        {
            const string sql = @"
            SELECT 
                value 
            FROM 
                sys.extended_properties 
            WHERE 
                major_id = OBJECT_ID(@FullTableName)
                AND minor_id = 0
                AND name = 'MS_Description'";

            using (var cmd = new SqlCommand(sql, conn, trans))
            {
                cmd.Parameters.AddWithValue("@FullTableName", $"{schema}.{tableName}");
                var result = cmd.ExecuteScalar();
                return result?.ToString() ?? string.Empty;
            }
        }

        // 更新表注释
        private void UpdateTableComment(SqlConnection conn, SqlTransaction trans, string schema, string tableName, string comment)
        {
            const string sql = @"
            IF EXISTS (
                SELECT 1 
                FROM sys.extended_properties 
                WHERE major_id = OBJECT_ID(@FullTableName)
                AND minor_id = 0
                AND name = 'MS_Description'
            )
            BEGIN
                EXEC sp_updateextendedproperty 
                    @name = N'MS_Description', 
                    @value = @Comment,
                    @level0type = N'SCHEMA', @level0name = @Schema,
                    @level1type = N'TABLE',  @level1name = @TableName
            END
            ELSE
            BEGIN
                EXEC sp_addextendedproperty 
                    @name = N'MS_Description', 
                    @value = @Comment,
                    @level0type = N'SCHEMA', @level0name = @Schema,
                    @level1type = N'TABLE',  @level1name = @TableName
            END";

            using (var cmd = new SqlCommand(sql, conn, trans))
            {
                cmd.Parameters.AddWithValue("@Schema", schema);
                cmd.Parameters.AddWithValue("@TableName", tableName);
                cmd.Parameters.AddWithValue("@FullTableName", $"{schema}.{tableName}");
                cmd.Parameters.AddWithValue("@Comment", comment);
                cmd.ExecuteNonQuery();
            }
        }

        // 解析表名中的架构（格式：Schema.TableName 或 TableName）
        private (string Schema, string TableName) ParseSchemaAndTableName(string fullTableName)
        {
            var parts = fullTableName.Split('.');
            return parts.Length switch
            {
                1 => ("dbo", parts[1]),
                2 => (parts[0], parts[1]),
                _ => throw new ArgumentException("Invalid table name format")
            };
        }
        #endregion
    
    

    

    
    }

}
