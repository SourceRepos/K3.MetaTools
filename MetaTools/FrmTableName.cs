using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaTools
{
    public partial class FrmTableName: Form
    {
        public FrmTableName()
        {
            InitializeComponent();
        }

        private void FrmTableName_Load(object sender, EventArgs e)
        {

            this.tABLESTableAdapter.Fill(this.dsK3Cloud.TABLES);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            find();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            find();

        }

        void find()
        {
            var drvTableName = this.tABLESBindingSource.Current as DataRowView;
            if (drvTableName != null)
            {
                var tableName = drvTableName["TABLE_NAME"].ToString();
                this.meta_TableItemTableAdapter.FillByTableName(this.dsK3Cloud.Meta_TableItem, tableName);
                if (this.dsK3Cloud.Meta_TableItem.Rows.Count <= 0)
                {
                    MessageBox.Show("没有找到数据表 "+tableName+" 相关元数据。");
                }
            }
        }

    }
}
