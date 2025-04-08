using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MetaTools
{
    public partial class FrmComment : Form
    {
        KernelXmlParser xmlParser;
        public FrmComment()
        {
            InitializeComponent();
        }

        private void FrmObjType_Load(object sender, EventArgs e)
        {
            xmlParser = new KernelXmlParser(dsK3Cloud);
            this.fIELDSTableAdapter.Fill(this.dsK3Cloud.FIELDS);
            this.tABLESTableAdapter.Fill(this.dsK3Cloud.TABLES);
            this.t_MDL_DOMAINMODETYPE_LTableAdapter.Fill(this.dsK3Cloud.T_MDL_DOMAINMODETYPE_L);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var drvModType = this.tMDLDOMAINMODETYPELBindingSource.Current as DataRowView;
            if (drvModType != null)
            {
                this.t_META_ObjectTypeTableAdapter.FillByModelTypeID(this.dsK3Cloud.T_META_ObjectType, Convert.ToInt32(drvModType["FID"]));
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

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataRowView drv in this.dsK3Cloud.T_META_ObjectType.DefaultView)
            {
                if (drv != null)
                {
                    var xmlContent = drv["FKERNELXML"].ToString();
                    if (!string.IsNullOrEmpty(xmlContent))
                    {
                        this.dsK3Cloud.EntityTable.Clear();
                        this.dsK3Cloud.FieldTable.Clear();
                        xmlParser.ParseXml(xmlContent);

                        var updater = new CommentTableUpdater(Properties.Settings.Default.K3C90ConnectionString);

                        var comments = new List<CommentTableUpdater.CommentInfo>();
                        foreach (DataRowView drvE in this.dsK3Cloud.EntityTable.DefaultView)
                        {
                            string tableName = drvE["TableName"].ToString();
                            if (!string.IsNullOrEmpty(tableName) && CommentTableUpdater.CheckValueExists(this.dsK3Cloud.TABLES, "TABLE_NAME", tableName))
                            {
                                string modelName = drv["ModelName"].ToString();
                                string metaName = drvE["Name"].ToString();
                                if (!string.IsNullOrEmpty(metaName))
                                {
                                    metaName = "_" + metaName;
                                }
                                string description = modelName + "_" + drvE["FrmName"].ToString() + metaName;

                                comments.Add(new CommentTableUpdater.CommentInfo
                                {
                                    TableName = tableName,
                                    Description = description,
                                });
                            }
                        }

                        if (comments.Count > 0)
                        {
                            updater.BatchUpdateComments(comments);

                        }

                    }
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (DataRowView drvObj in this.dsK3Cloud.T_META_ObjectType.DefaultView)
            {
                if (drvObj != null)
                {
                    var xmlContent = drvObj["FKERNELXML"].ToString();
                    if (!string.IsNullOrEmpty(xmlContent))
                    {
                        this.dsK3Cloud.EntityTable.Clear();
                        this.dsK3Cloud.FieldTable.Clear();
                        xmlParser.ParseXml(xmlContent);

                        foreach (DataRow drTab in this.dsK3Cloud.EntityTable.Rows)
                        {
                            string entityKey = drTab["Key"].ToString();
                            string tableName = drTab["TableName"].ToString();
                            if (!string.IsNullOrEmpty(entityKey))
                            {
                                DataRow[] drs = this.dsK3Cloud.FieldTable.Select("EntityKey='" + entityKey + "'");
                                DataRow[] drF = this.dsK3Cloud.FIELDS.Select("TableName='" + tableName + "'");

                                if (drF.Length > 0 && drs.Length > 0)
                                {

                                    string connectionString = Properties.Settings.Default.K3C90ConnectionString;
                                    string schema = "dbo";

                                    var columnComments = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

                                    foreach (DataRow fRow in drF)
                                    {
                                        string columnName = fRow.Field<string>("ColumnName")?.Trim() ?? string.Empty;
                                        if (string.IsNullOrEmpty(columnName)) continue;

                                        foreach (DataRow sRow in drs)
                                        {
                                            string key = sRow.Field<string>("Key")?.Trim() ?? string.Empty;
                                            string fieldName = sRow.Field<string>("FieldName")?.Trim() ?? string.Empty;
                                            string propertyName = sRow.Field<string>("PropertyName")?.Trim() ?? string.Empty;
                                            string name = sRow.Field<string>("Name")?.Trim() ?? string.Empty;

                                            bool isMatch = string.Equals(columnName, key, StringComparison.OrdinalIgnoreCase)
                                                        || string.Equals(columnName, fieldName, StringComparison.OrdinalIgnoreCase)
                                                        || string.Equals(columnName, propertyName, StringComparison.OrdinalIgnoreCase);

                                            if (isMatch)
                                            {
                                                // 避免重复添加，若已存在则保留第一个匹配项
                                                if (!columnComments.ContainsKey(columnName))
                                                {
                                                    columnComments.Add(columnName, name);
                                                }
                                                break; // 匹配后跳出当前循环，继续处理下一个列名
                                            }
                                        }
                                    }

                                    CommentFieldUpdater.UpdateAllColumnComments(
                                        connectionString,
                                        schema,
                                        tableName,
                                        columnComments
                                    );

                                }
                            }


                        }




                    }
                }

            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.t_META_ObjectTypeTableAdapter.Fill(this.dsK3Cloud.T_META_ObjectType);
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var updater = new TableCommentUpdater(Properties.Settings.Default.K3C90ConnectionString);
            // 1. 删除所有表注释
            updater.DeleteAllTableComments();
        }
    }
}
