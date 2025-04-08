//using Microsoft.Data.ConnectionUI;
using Microsoft.Data.ConnectionUI;
using System;
using System.Windows.Forms;

namespace MetaTools
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void FormShow(Form frm)
        {
            try
            {
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) 
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK) 
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void 系统元数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            this.FormShow(new FrmObjectType());
        }

        private void 依表名查看元数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {           
           this.FormShow(new FrmTableName());
        }


        private void tetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CfgOptions cfg = new CfgOptions();
            cfg.SetConnString();

        }

        private void 模块类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          FormShow(new FrmModelType());
        }

        private void 设置数据表注释ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new FrmTableMeta());
        }

        private void 元数据列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new FrmComment());
        }

        private void 字段信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new FrmFieldInfo());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.ShowDialog();
        }

        private void 用户表信息查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new FrmTableInfo());
        }

        private void 根据值查数据表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new FrmSearch());
        }
    }
}
