using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MetaTools
{
    public class CommentTableUpdater
    {
        private readonly string _connectionString;

        public CommentTableUpdater(string connectionString)
        {
            _connectionString = connectionString;
        }

        // 定义注释信息类
        public class CommentInfo
        {
            public string TableName { get; set; }
            public string ColumnName { get; set; } // 如果为null则表示表注释
            public string Description { get; set; }
        }

        // 批量更新注释
        public void BatchUpdateComments(IEnumerable<CommentInfo> comments)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var comment in comments)
                        {
                            UpdateComment(connection, transaction, comment);
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

        private void UpdateComment(SqlConnection conn, SqlTransaction trans, CommentInfo comment)
        {
            string sql;
            if (string.IsNullOrEmpty(comment.ColumnName))
            {
                // 表注释
                sql = @"
                IF EXISTS (
                    SELECT 1 
                    FROM sys.extended_properties 
                    WHERE major_id = OBJECT_ID(@TableName) 
                    AND minor_id = 0 
                    AND name = 'MS_Description'
                )
                BEGIN
                    EXEC sp_updateextendedproperty 
                        @name = N'MS_Description', 
                        @value = @Description,
                        @level0type = N'SCHEMA', @level0name = N'dbo',
                        @level1type = N'TABLE', @level1name = @TableName
                END
                ELSE
                BEGIN
                    EXEC sp_addextendedproperty 
                        @name = N'MS_Description', 
                        @value = @Description,
                        @level0type = N'SCHEMA', @level0name = N'dbo',
                        @level1type = N'TABLE', @level1name = @TableName
                END";
            }
            else
            {
                // 列注释
                sql = @"
                IF EXISTS (
                    SELECT 1 
                    FROM sys.extended_properties 
                    WHERE major_id = OBJECT_ID(@TableName) 
                    AND minor_id = COLUMNPROPERTY(major_id, @ColumnName, 'ColumnId')
                    AND name = 'MS_Description'
                )
                BEGIN
                    EXEC sp_updateextendedproperty 
                        @name = N'MS_Description', 
                        @value = @Description,
                        @level0type = N'SCHEMA', @level0name = N'dbo',
                        @level1type = N'TABLE', @level1name = @TableName,
                        @level2type = N'COLUMN', @level2name = @ColumnName
                END
                ELSE
                BEGIN
                    EXEC sp_addextendedproperty 
                        @name = N'MS_Description', 
                        @value = @Description,
                        @level0type = N'SCHEMA', @level0name = N'dbo',
                        @level1type = N'TABLE', @level1name = @TableName,
                        @level2type = N'COLUMN', @level2name = @ColumnName
                END";
            }

            using (var cmd = new SqlCommand(sql, conn, trans))
            {

                cmd.Parameters.AddWithValue("@TableName", comment.TableName);
                cmd.Parameters.AddWithValue("@Description", comment.Description);
                if (!string.IsNullOrEmpty(comment.ColumnName))
                {
                    cmd.Parameters.AddWithValue("@ColumnName", comment.ColumnName);
                }
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 检查 DataTable 的指定列中是否存在目标值
        /// </summary>
        /// <param name="dataTable">目标 DataTable</param>
        /// <param name="columnName">要检查的列名（如 "TABLE_NAME"）</param>
        /// <param name="targetValue">要匹配的目标值</param>
        /// <param name="ignoreCase">是否忽略大小写（默认：是）</param>
        /// <returns>存在返回 true，否则返回 false</returns>
        public static bool CheckValueExists(
            DataTable dataTable,
            string columnName,
            string targetValue,
            bool ignoreCase = true
        )
        {
            // 1. 检查列是否存在
            if (!dataTable.Columns.Contains(columnName))
            {
                return false;
            }

            // 2. 使用 LINQ 遍历行并匹配值
            return dataTable.AsEnumerable().Any(row =>
            {
                object value = row[columnName];

                // 跳过空值
                if (value == DBNull.Value || value == null)
                {
                    return false;
                }

                // 比较字符串（根据 ignoreCase 参数决定是否忽略大小写）
                StringComparison comparison = ignoreCase
                    ? StringComparison.OrdinalIgnoreCase
                    : StringComparison.Ordinal;

                return value.ToString().Equals(targetValue, comparison);
            });
        }

    }
}