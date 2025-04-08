namespace MetaTools
{
    partial class FrmTableName
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tABLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsK3Cloud = new MetaTools.Model.DsK3Cloud();
            this.tABLESTableAdapter = new MetaTools.Model.DsK3CloudTableAdapters.TABLESTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.meta_TableItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meta_TableItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new MetaTools.Model.DsK3CloudTableAdapters.TableAdapterManager();
            this.meta_TableItemTableAdapter = new MetaTools.Model.DsK3CloudTableAdapters.Meta_TableItemTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tABLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsK3Cloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meta_TableItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meta_TableItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tABLESBindingSource;
            this.listBox1.DisplayMember = "TABLE_NAME";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 660);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "TABLE_NAME";
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // tABLESBindingSource
            // 
            this.tABLESBindingSource.DataMember = "TABLES";
            this.tABLESBindingSource.DataSource = this.dsK3Cloud;
            // 
            // dsK3Cloud
            // 
            this.dsK3Cloud.DataSetName = "DsK3Cloud";
            this.dsK3Cloud.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tABLESTableAdapter
            // 
            this.tABLESTableAdapter.ClearBeforeFill = true;
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1229, 700);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 700);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据表信息：";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.tABLESBindingSource;
            this.comboBox1.DisplayMember = "TABLE_NAME";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "TABLE_NAME";
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
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(982, 700);
            this.splitContainer2.SplitterDistance = 49;
            this.splitContainer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.meta_TableItemDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 647);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "元数据记录：";
            // 
            // meta_TableItemDataGridView
            // 
            this.meta_TableItemDataGridView.AllowUserToAddRows = false;
            this.meta_TableItemDataGridView.AllowUserToDeleteRows = false;
            this.meta_TableItemDataGridView.AutoGenerateColumns = false;
            this.meta_TableItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meta_TableItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.meta_TableItemDataGridView.DataSource = this.meta_TableItemBindingSource;
            this.meta_TableItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meta_TableItemDataGridView.Location = new System.Drawing.Point(3, 17);
            this.meta_TableItemDataGridView.Name = "meta_TableItemDataGridView";
            this.meta_TableItemDataGridView.ReadOnly = true;
            this.meta_TableItemDataGridView.RowHeadersWidth = 30;
            this.meta_TableItemDataGridView.RowTemplate.Height = 23;
            this.meta_TableItemDataGridView.Size = new System.Drawing.Size(976, 627);
            this.meta_TableItemDataGridView.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FKERNELXML";
            this.dataGridViewTextBoxColumn3.HeaderText = "FKERNELXML";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FMODELTYPEID";
            this.dataGridViewTextBoxColumn5.HeaderText = "FMODELTYPEID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ModelName";
            this.dataGridViewTextBoxColumn6.HeaderText = "ModelName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TabItem";
            this.dataGridViewTextBoxColumn7.HeaderText = "TabItem";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // meta_TableItemBindingSource
            // 
            this.meta_TableItemBindingSource.DataMember = "Meta_TableItem";
            this.meta_TableItemBindingSource.DataSource = this.dsK3Cloud;
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
            // meta_TableItemTableAdapter
            // 
            this.meta_TableItemTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Like模式查询";
            // 
            // FrmTableName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 700);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmTableName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据表查元数据";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTableName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tABLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsK3Cloud)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meta_TableItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meta_TableItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private Model.DsK3Cloud dsK3Cloud;
        private System.Windows.Forms.BindingSource tABLESBindingSource;
        private Model.DsK3CloudTableAdapters.TABLESTableAdapter tABLESTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource meta_TableItemBindingSource;
        private Model.DsK3CloudTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView meta_TableItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Model.DsK3CloudTableAdapters.Meta_TableItemTableAdapter meta_TableItemTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}