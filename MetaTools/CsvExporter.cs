using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetaTools
{


    public class CsvExporter
    {
        public static void ExportDataTableToCsvWithDialog(DataTable dataTable)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("无有效数据可导出！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 弹窗设置
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "CSV文件 (*.csv)|*.csv";
                saveDialog.DefaultExt = "csv";
                saveDialog.AddExtension = true;
                saveDialog.Title = "保存CSV文件";
                saveDialog.FileName = "ExportData.csv";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 写入CSV核心逻辑
                        using (StreamWriter sw = new StreamWriter(saveDialog.FileName, false, Encoding.UTF8))
                        {
                            // 写入列头
                            sw.WriteLine(string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(c => EscapeCsvField(c.ColumnName))));

                            // 写入数据行
                            foreach (DataRow row in dataTable.Rows)
                            {
                                var fields = row.ItemArray.Select(f => EscapeCsvField(f?.ToString() ?? ""));
                                sw.WriteLine(string.Join(",", fields));
                            }
                        }

                        MessageBox.Show("导出成功！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"导出失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // CSV字段转义方法
        private static string EscapeCsvField(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";

            bool needsQuotes = input.Contains(",") || input.Contains("\"") || input.Contains("\n");
            string escaped = input.Replace("\"", "\"\"");
            return needsQuotes ? $"\"{escaped}\"" : escaped;
        }
    }

}
