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
    public partial class FrmFieldInfo: Form
    {
        public FrmFieldInfo()
        {
            InitializeComponent();
        }

        private void FrmFieldInfo_Load(object sender, EventArgs e)
        {

            this.cOLUMNSTableAdapter.Fill(this.dsK3Cloud.COLUMNS);

        }

        private void cOLUMNSBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var drv = (DataRowView)cOLUMNSBindingSource.Current;
            if (drv!=null)
            {
                this.fIELDSTableAdapter.FillByFieldName(this.dsK3Cloud.FIELDS, drv["COLUMN_NAME"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CsvExporter.ExportDataTableToCsvWithDialog(this.dsK3Cloud.FIELDS);
        }
    }
}
