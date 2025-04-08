using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MetaTools
{
    public partial class FrmObjectType : Form
    {
        KernelXmlParser xmlParser;
        public FrmObjectType()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xmlParser = new KernelXmlParser(dsK3Cloud);    
            DataLoad();

        }

        private void DataLoad()
        {
            this.mataObjectTypeTableAdapter.Fill(this.dsK3Cloud.MataObjectType);
            this.mataSubSystemTableAdapter.Fill(this.dsK3Cloud.MataSubSystem);
            this.mataTopClassTableAdapter.Fill(this.dsK3Cloud.MataTopClass);

            foreach (DataRow drTop in dsK3Cloud.MataTopClass.Rows)
            {
                TreeNode treeNode = new TreeNode(drTop["FName"].ToString());
                treeView1.Nodes.Add(treeNode);
                var subSystem = dsK3Cloud.MataSubSystem.Select("PID='" + drTop["ID"] + "'");
                foreach (DataRow drSub in subSystem)
                {
                    TreeNode treeNodeSub = new TreeNode(drSub["FName"].ToString());
                    treeNode.Nodes.Add(treeNodeSub);
                    var objectType = dsK3Cloud.MataObjectType.Select("PID='" + drSub["ID"] + "'");
                    foreach (DataRow drObj in objectType)
                    {
                        TreeNode treeNodeObj = new TreeNode(drObj["FName"].ToString());
                        treeNodeObj.Tag = drObj["ID"].ToString();

                        treeNodeSub.Nodes.Add(treeNodeObj);
                    }
                }


            }

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Tag != null)
            {
                string id = node.Tag.ToString();

                this.t_META_ObjectTypeTableAdapter.FillByFID(this.dsK3Cloud.T_META_ObjectType, id);
                if (this.dsK3Cloud.T_META_ObjectType.Rows.Count > 0)
                {
                    var xmlContent = this.dsK3Cloud.T_META_ObjectType.Rows[0]["FKERNELXML"].ToString();
                    if (!string.IsNullOrEmpty(xmlContent))
                    {
                        this.dsK3Cloud.EntityTable.Clear();
                        this.dsK3Cloud.FieldTable.Clear();
                        xmlParser.ParseXml(xmlContent);

                    }
                }

            }
        }

        private void entityTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (entityTableBindingSource.Current != null)
            {
                fieldTableBindingSource.Filter = checkBox1.Checked == true ? "EntityKey='" + ((DataRowView)entityTableBindingSource.Current)["Key"] + "'" : "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (entityTableBindingSource.Current != null)
            {
                fieldTableBindingSource.Filter = checkBox1.Checked == true ? "EntityKey='" + ((DataRowView)entityTableBindingSource.Current)["Key"] + "'" : "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)t_META_ObjectTypeBindingSource.Current;
            if (drv != null)
            {
                // 配置保存文件对话框
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Title = "保存 XML 文件";
                    saveDialog.Filter = "XML 文件 (*.xml)|*.xml|所有文件 (*.*)|*.*";
                    saveDialog.DefaultExt = "xml";
                    saveDialog.AddExtension = true;
                    saveDialog.OverwritePrompt = true;
                    saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    saveDialog.FileName = drv["FNAME"] + ".xml";
                    // 显示对话框
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {

                            // 使用 UTF-8 编码保存（带 BOM）
                            File.WriteAllText(saveDialog.FileName, drv["FKERNELXML"].ToString(), Encoding.UTF8);
                            MessageBox.Show($"文件已成功保存到：{saveDialog.FileName}",
                                           "保存成功",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"保存失败：{ex.Message}",
                                           "错误",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)t_META_ObjectTypeBindingSource.Current;
            if (drv != null)
            {

                Clipboard.SetDataObject(drv["FKERNELXML"].ToString(), true);

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CsvExporter.ExportDataTableToCsvWithDialog(this.dsK3Cloud.EntityTable);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CsvExporter.ExportDataTableToCsvWithDialog(this.dsK3Cloud.FieldTable);
        }
    }
}