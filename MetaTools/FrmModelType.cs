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
    public partial class FrmModelType : Form
    {
        public FrmModelType()
        {
            InitializeComponent();
        }


        private void FrmModelType_Load(object sender, EventArgs e)
        {
            this.t_MDL_DOMAINMODETYPE_LTableAdapter.Fill(this.dsK3Cloud.T_MDL_DOMAINMODETYPE_L);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CsvExporter.ExportDataTableToCsvWithDialog(this.dsK3Cloud.T_MDL_DOMAINMODETYPE_L);
        }
    }
}
