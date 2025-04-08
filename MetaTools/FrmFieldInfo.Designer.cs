namespace MetaTools
{
    partial class FrmFieldInfo
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cOLUMNSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsK3Cloud = new MetaTools.Model.DsK3Cloud();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fIELDSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIELDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOLUMNSTableAdapter = new MetaTools.Model.DsK3CloudTableAdapters.COLUMNSTableAdapter();
            this.fIELDSTableAdapter = new MetaTools.Model.DsK3CloudTableAdapters.FIELDSTableAdapter();
            this.tableAdapterManager = new MetaTools.Model.DsK3CloudTableAdapters.TableAdapterManager();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOLUMNSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsK3Cloud)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fIELDSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIELDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1379, 607);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 607);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字段列表：";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.cOLUMNSBindingSource;
            this.listBox1.DisplayMember = "COLUMN_NAME";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 567);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "COLUMN_NAME";
            // 
            // cOLUMNSBindingSource
            // 
            this.cOLUMNSBindingSource.DataMember = "COLUMNS";
            this.cOLUMNSBindingSource.DataSource = this.dsK3Cloud;
            this.cOLUMNSBindingSource.CurrentChanged += new System.EventHandler(this.cOLUMNSBindingSource_CurrentChanged);
            // 
            // dsK3Cloud
            // 
            this.dsK3Cloud.DataSetName = "DsK3Cloud";
            this.dsK3Cloud.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cOLUMNSBindingSource;
            this.comboBox1.DisplayMember = "COLUMN_NAME";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "COLUMN_NAME";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fIELDSDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1158, 607);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "字段使用信息：";
            // 
            // fIELDSDataGridView
            // 
            this.fIELDSDataGridView.AllowUserToAddRows = false;
            this.fIELDSDataGridView.AllowUserToDeleteRows = false;
            this.fIELDSDataGridView.AutoGenerateColumns = false;
            this.fIELDSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.fIELDSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fIELDSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.fIELDSDataGridView.DataSource = this.fIELDSBindingSource;
            this.fIELDSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fIELDSDataGridView.Location = new System.Drawing.Point(3, 17);
            this.fIELDSDataGridView.Name = "fIELDSDataGridView";
            this.fIELDSDataGridView.ReadOnly = true;
            this.fIELDSDataGridView.RowTemplate.Height = 23;
            this.fIELDSDataGridView.Size = new System.Drawing.Size(1152, 587);
            this.fIELDSDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SchemaName";
            this.dataGridViewTextBoxColumn1.HeaderText = "SchemaName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TableName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TableName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 84;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TableDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "TableDescription";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 126;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ColumnName";
            this.dataGridViewTextBoxColumn4.HeaderText = "ColumnName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataType";
            this.dataGridViewTextBoxColumn5.HeaderText = "DataType";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 78;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaxLength";
            this.dataGridViewTextBoxColumn6.HeaderText = "MaxLength";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 84;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Precision";
            this.dataGridViewTextBoxColumn7.HeaderText = "Precision";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 84;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Scale";
            this.dataGridViewTextBoxColumn8.HeaderText = "Scale";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IsNullable";
            this.dataGridViewTextBoxColumn9.HeaderText = "IsNullable";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 90;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IsPrimaryKey";
            this.dataGridViewTextBoxColumn10.HeaderText = "IsPrimaryKey";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 102;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ColumnDescription";
            this.dataGridViewTextBoxColumn11.HeaderText = "ColumnDescription";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 132;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ColumnOrder";
            this.dataGridViewTextBoxColumn12.HeaderText = "ColumnOrder";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 96;
            // 
            // fIELDSBindingSource
            // 
            this.fIELDSBindingSource.DataMember = "FIELDS";
            this.fIELDSBindingSource.DataSource = this.dsK3Cloud;
            // 
            // cOLUMNSTableAdapter
            // 
            this.cOLUMNSTableAdapter.ClearBeforeFill = true;
            // 
            // fIELDSTableAdapter
            // 
            this.fIELDSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CMK_API_WHITEIPSETTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.T_MDL_DOMAINMODETYPE_LTableAdapter = null;
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
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1379, 645);
            this.splitContainer2.SplitterDistance = 34;
            this.splitContainer2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询同名字段所在的表";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "导出到CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFieldInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 645);
            this.Controls.Add(this.splitContainer2);
            this.Name = "FrmFieldInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字段使用信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFieldInfo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cOLUMNSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsK3Cloud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fIELDSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIELDSBindingSource)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private Model.DsK3Cloud dsK3Cloud;
        private System.Windows.Forms.BindingSource cOLUMNSBindingSource;
        private Model.DsK3CloudTableAdapters.COLUMNSTableAdapter cOLUMNSTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource fIELDSBindingSource;
        private Model.DsK3CloudTableAdapters.FIELDSTableAdapter fIELDSTableAdapter;
        private Model.DsK3CloudTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fIELDSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}