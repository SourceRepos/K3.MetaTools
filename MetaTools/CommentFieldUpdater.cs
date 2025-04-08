using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MetaTools
{

    public class CommentFieldUpdater
    {
        /// <summary>
        /// 批量更新表中所有字段的注释
        /// </summary>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <param name="schemaName">架构名（如 dbo）</param>
        /// <param name="tableName">表名</param>
        /// <param name="columnComments">字段注释字典（Key=列名，Value=注释）</param>
        /// <param name="useTransaction">是否启用事务（默认true）</param>
        public static void UpdateAllColumnComments(
            string connectionString,
            string schemaName,
            string tableName,
            Dictionary<string, string> columnComments,
            bool useTransaction = true)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = useTransaction ? connection.BeginTransaction() : null;

                try
                {
                    foreach (var kvp in columnComments)
                    {
                        string columnName = kvp.Key;
                        string comment = kvp.Value;

                        // 重用单个字段更新方法
                        UpdateColumnCommentInternal(
                            connection,
                            transaction,
                            schemaName,
                            tableName,
                            columnName,
                            comment
                        );
                    }

                    transaction?.Commit();
                }
                catch (Exception)
                {
                    transaction?.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// 内部方法：更新单个字段注释（支持事务）
        /// </summary>
        private static void UpdateColumnCommentInternal(
            SqlConnection connection,
            SqlTransaction transaction,
            string schemaName,
            string tableName,
            string columnName,
            string comment)
        {
            // 检查注释是否存在
            bool commentExists = CheckColumnCommentExists(connection,transaction, schemaName, tableName, columnName);

            string procedureName = commentExists ? "sp_updateextendedproperty" : "sp_addextendedproperty";

            using (SqlCommand command = new SqlCommand(procedureName, connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;

                // 参数配置
                command.Parameters.AddWithValue("@name", "MS_Description");
                command.Parameters.AddWithValue("@value", comment);

                // 层级参数
                command.Parameters.Add(new SqlParameter("@level0type", "SCHEMA"));
                command.Parameters.AddWithValue("@level0name", schemaName);
                command.Parameters.Add(new SqlParameter("@level1type", "TABLE"));
                command.Parameters.AddWithValue("@level1name", tableName);
                command.Parameters.Add(new SqlParameter("@level2type", "COLUMN"));
                command.Parameters.AddWithValue("@level2name", columnName);

                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 检查字段注释是否存在（复用之前的实现）
        /// </summary>
        private static bool CheckColumnCommentExists(
            SqlConnection connection,
            SqlTransaction transaction,
            string schemaName,
            string tableName,
            string columnName)
        {
            string query = @"
            SELECT COUNT(*) 
            FROM sys.extended_properties ep
            JOIN sys.tables t ON ep.major_id = t.object_id
            JOIN sys.schemas s ON t.schema_id = s.schema_id
            JOIN sys.columns c ON ep.major_id = c.object_id AND ep.minor_id = c.column_id
            WHERE s.name = @schemaName
            AND t.name = @tableName
            AND c.name = @columnName
            AND ep.name = 'MS_Description'";

            using (SqlCommand command = new SqlCommand(query, connection,transaction))
            {
                command.Parameters.AddWithValue("@schemaName", schemaName);
                command.Parameters.AddWithValue("@tableName", tableName);
                command.Parameters.AddWithValue("@columnName", columnName);

                return (int)command.ExecuteScalar() > 0;
            }
        }


    }


}
