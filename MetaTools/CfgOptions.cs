using Microsoft.Data.ConnectionUI;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace MetaTools
{
    public class CfgOptions
    {
        public void SetConnString()
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string connectionStringName = "MetaTools.Properties.Settings.K3C90ConnectionString";
            string newConnectionString = Properties.Settings.Default.K3C90ConnectionString;

            try
            {
                DataConnectionDialog dlg = new DataConnectionDialog();
                dlg.DataSources.Clear();
                dlg.DataSources.Add(DataSource.SqlDataSource); 
                dlg.SelectedDataSource = DataSource.SqlDataSource;
                dlg.SelectedDataProvider = DataProvider.SqlDataProvider;
                dlg.ConnectionString = newConnectionString;

               var yn= DataConnectionDialog.Show(dlg);
                if (yn == DialogResult.OK &&!string.IsNullOrEmpty(dlg.ConnectionString))
                {
                    newConnectionString = dlg.ConnectionString;

                    Configuration config = ConfigurationManager.OpenExeConfiguration(exePath);
                    ConnectionStringsSection section = config.ConnectionStrings;
                    ConnectionStringSettings oldSettings = section.ConnectionStrings[connectionStringName];
                    if (oldSettings != null)
                    {
                        section.ConnectionStrings.Remove(connectionStringName);
                        section.ConnectionStrings.Add(new ConnectionStringSettings(
                            connectionStringName,
                            newConnectionString,
                            oldSettings.ProviderName));

                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("connectionStrings");
                        System.Windows.Forms.MessageBox.Show("数据库连接设置成功，重新启动程序。");
                        RestartApplication();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show($"未找到名称为 '{connectionStringName}' 的连接字符串。");
                    }
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"发生错误：{ex.Message}");
            }

        }

        private void RestartApplication()
        {
            // 获取当前程序路径和参数
            string exePath = Application.ExecutablePath;
            string[] args = GetCleanedArguments();

            // 创建启动参数
            var startInfo = new ProcessStartInfo
            {
                FileName = exePath,
                Arguments = EscapeArguments(args),
                UseShellExecute = true,
                WorkingDirectory = Environment.CurrentDirectory
            };

            // 启动新进程
            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"启动失败: {ex.Message}");
                return;
            }

            // 彻底关闭当前程序
            Application.Exit();
            Environment.Exit(0); // 双重确保退出
        }

        // 获取清理后的参数（跳过第一个参数）
        private static string[] GetCleanedArguments()
        {
            return Environment.GetCommandLineArgs()
                   .Skip(1) // 跳过可执行文件自身路径
                   .ToArray();
        }

        // 参数转义处理
        private static string EscapeArguments(string[] args)
        {
            return string.Join(" ", args.Select(arg =>
            {
                if (string.IsNullOrEmpty(arg)) return "\"\"";
                if (arg.Contains(" ") || arg.Contains("\""))
                    return $"\"{arg.Replace("\"", "\\\"")}\"";
                return arg;
            }));
        }

    }
}
