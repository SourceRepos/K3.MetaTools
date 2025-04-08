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
    public partial class FrmTableInfo: Form
    {
        public FrmTableInfo()
        {
            InitializeComponent();
        }

        private void FrmTableInfo_Load(object sender, EventArgs e)
        {
            this.tABLESTableAdapter.FillByNotNull(this.dsK3Cloud.TABLES);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.tABLESTableAdapter.Fill(this.dsK3Cloud.TABLES);
            }
            else
            {
                this.tABLESTableAdapter.FillByNotNull(this.dsK3Cloud.TABLES);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CsvExporter.ExportDataTableToCsvWithDialog(this.dsK3Cloud.TABLES);
        }
    }
}
