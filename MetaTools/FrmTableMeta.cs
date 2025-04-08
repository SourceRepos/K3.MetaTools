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
    public partial class FrmTableMeta : Form
    {
        KernelXmlParser xmlParser;

        public FrmTableMeta()
        {
            InitializeComponent();
        }

        private void FrmSetComment_Load(object sender, EventArgs e)
        {

            xmlParser = new KernelXmlParser(dsK3Cloud);
            this.tABLESTableAdapter.Fill(this.dsK3Cloud.TABLES);


        }

        private void tABLESBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var drvTable = tABLESBindingSource.Current as DataRowView;
            if (drvTable != null)
            {
                var tabName = drvTable["TABLE_NAME"].ToString();
                this.fIELDSTableAdapter.FillByTableName(this.dsK3Cloud.FIELDS, tabName);
                this.dsK3Cloud.T_META_ObjectType.Clear();
                this.dsK3Cloud.EntityTable.Clear();
                this.dsK3Cloud.FieldTable.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var drvTableName = this.tABLESBindingSource.Current as DataRowView;
            if (drvTableName != null)
            {
                var tableName = drvTableName["TABLE_NAME"].ToString();
                //string selectStr = "SELECT a.* ,b.FNAME, c.FNAME as ModelName FROM T_META_ObjectType a LEFT JOIN T_META_ObjectType_L b on a.FID=b.FID and b.FLOCALEID=2052 LEFT JOIN  T_MDL_DOMAINMODETYPE_L AS c ON a.FMODELTYPEID = c.FID AND c.FLOCALEID = 2052 WHERE FKERNELXML.exist('//TableName[text()=''" + tableName+"'']') =1 ";
                //System.Data.SqlClient.SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(selectStr, this.t_META_ObjectTypeTableAdapter.Connection);
                //this.dsK3Cloud.T_META_ObjectType.Clear();
                //sqlDataAdapter.Fill(this.dsK3Cloud.T_META_ObjectType);
                this.t_META_ObjectTypeTableAdapter.FillByTableName(this.dsK3Cloud.T_META_ObjectType, tableName);
                if (this.dsK3Cloud.T_META_ObjectType.Rows.Count<=0)
                {
                    MessageBox.Show("没有找到使用数据表："+tableName+"  的元数据。");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.t_META_ObjectTypeBindingSource.Current;
            if (drv != null)
            {
                var xmlContent = drv["FKERNELXML"].ToString();
                if (!string.IsNullOrEmpty(xmlContent))
                {
                    this.dsK3Cloud.EntityTable.Clear();
                    this.dsK3Cloud.FieldTable.Clear();
                    xmlParser.ParseXml(xmlContent);

                }
            }
        }
    }
}
