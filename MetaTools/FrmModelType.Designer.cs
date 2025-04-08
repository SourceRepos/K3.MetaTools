namespace MetaTools
{
    partial class FrmModelType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dsK3Cloud = new MetaTools.Model.DsK3Cloud();
            this.t_MDL_DOMAINMODETYPE_LBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_MDL_DOMAINMODETYPE_LTableAdapter = new MetaTools.Model.DsK3CloudTableAdapters.T_MDL_DOMAINMODETYPE_LTableAdapter();
            this.tableAdapterManager = new MetaTools.Model.DsK3CloudTableAdapters.TableAdapterManager();
            this.t_MDL_DOMAINMODETYPE_LDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsK3Cloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MDL_DOMAINMODETYPE_LBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MDL_DOMAINMODETYPE_LDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsK3Cloud
            // 
            this.dsK3Cloud.DataSetName = "DsK3Cloud";
            this.dsK3Cloud.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_MDL_DOMAINMODETYPE_LBindingSource
            // 
            this.t_MDL_DOMAINMODETYPE_LBindingSource.DataMember = "T_MDL_DOMAINMODETYPE_L";
            this.t_MDL_DOMAINMODETYPE_LBindingSource.DataSource = this.dsK3Cloud;
            // 
            // t_MDL_DOMAINMODETYPE_LTableAdapter
            // 
            this.t_MDL_DOMAINMODETYPE_LTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CMK_API_WHITEIPSETTableAdapter = null;
            this.tableAdapterManager.T_MDL_DOMAINMODETYPE_LTableAdapter = this.t_MDL_DOMAINMODETYPE_LTableAdapter;
            this.tableAdapterManager.T_MDL_DOMAINMODETYPETableAdapter = null;
            this.tableAdapterManager.T_META_BaseDataFlexType_LTableAdapter = null;
            this.tableAdapterManager.T_META_BaseDataFlexTypeTableAdapter = null;
            this.tableAdapterManager.T_META_BaseDataType_LTableAdapter = null;
            this.tableAdapterManager.T_META_BaseDataTypeTableAdapter = null;
            this.tableAdapterManager.T_META_BillParaDynPluginTableAdapter = null;
            this.tableAdapterManager.T_META_BosRegInfoTableAdapter = null;
            this.tableAdapterManager.T_META_ConsoleDetail_LTableAdapter = null;
            this.tableAdapterManager.T_META_ConsoleDetailTableAdapter = null;
            this.tableAdapterManager.T_META_ConsoleMenu_PluginTableAdapter = null;
            this.tableAdapterManager.T_META_ConsoleSubFunc_LTableAdapter = null;
            this.tableAdapterManager.T_META_ConsoleSubFuncTableAdapter = null;
            this.tableAdapterManager.T_META_ConvertLookUpTableAdapter = null;
            this.tableAdapterManager.T_META_ConvertRule_LTableAdapter = null;
            this.tableAdapterManager.T_META_ConvertRuleTableAdapter = null;
            this.tableAdapterManager.T_META_DynamicServiceModelTableAdapter = null;
            this.tableAdapterManager.T_META_FieldFunctionControlTableAdapter = null;
            this.tableAdapterManager.T_META_FormBillListTableAdapter = null;
            this.tableAdapterManager.T_META_FormEnumTableAdapter = null;
            this.tableAdapterManager.T_META_NeedTypeBillTableAdapter = null;
            this.tableAdapterManager.T_META_ObjectType_LTableAdapter = null;
            this.tableAdapterManager.T_META_SubSystem_LTableAdapter = null;
            this.tableAdapterManager.T_META_SubSystemTableAdapter = null;
            this.tableAdapterManager.T_META_TopClass_LTableAdapter = null;
            this.tableAdapterManager.T_META_TopClassTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MetaTools.Model.DsK3CloudTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_MDL_DOMAINMODETYPE_LDataGridView
            // 
            this.t_MDL_DOMAINMODETYPE_LDataGridView.AllowUserToAddRows = false;
            this.t_MDL_DOMAINMODETYPE_LDataGridView.AllowUserToDeleteRows = false;
            this.t_MDL_DOMAINMODETYPE_LDataGridView.AutoGenerateColumns = false;
            this.t_MDL_DOMAINMODETYPE_LDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.t_MDL_DOMAINMODETYPE_LDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_MDL_DOMAINMODETYPE_LDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.t_MDL_DOMAINMODETYPE_LDataGridView.DataSource = this.t_MDL_DOMAINMODETYPE_LBindingSource;
            this.t_MDL_DOMAINMODETYPE_LDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_MDL_DOMAINMODETYPE_LDataGridView.Location = new System.Drawing.Point(0, 0);
            this.t_MDL_DOMAINMODETYPE_LDataGridView.Name = "t_MDL_DOMAINMODETYPE_LDataGridView";
            this.t_MDL_DOMAINMODETYPE_LDataGridView.ReadOnly = true;
            this.t_MDL_DOMAINMODETYPE_LDataGridView.RowTemplate.Height = 23;
            this.t_MDL_DOMAINMODETYPE_LDataGridView.Size = new System.Drawing.Size(1017, 591);
            this.t_MDL_DOMAINMODETYPE_LDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "FNAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FLOCALEID";
            this.dataGridViewTextBoxColumn3.HeaderText = "FLOCALEID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FPKID";
            this.dataGridViewTextBoxColumn4.HeaderText = "FPKID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.t_MDL_DOMAINMODETYPE_LDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1017, 640);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "导出到CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmModelType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 640);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmModelType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模块类型";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmModelType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsK3Cloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MDL_DOMAINMODETYPE_LBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MDL_DOMAINMODETYPE_LDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Model.DsK3Cloud dsK3Cloud;
        private System.Windows.Forms.BindingSource t_MDL_DOMAINMODETYPE_LBindingSource;
        private Model.DsK3CloudTableAdapters.T_MDL_DOMAINMODETYPE_LTableAdapter t_MDL_DOMAINMODETYPE_LTableAdapter;
        private Model.DsK3CloudTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView t_MDL_DOMAINMODETYPE_LDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
    }
}