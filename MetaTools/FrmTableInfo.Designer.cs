namespace MetaTools
{
    partial class FrmTableInfo
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tABLESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tABLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsK3Cloud = new MetaTools.Model.DsK3Cloud();
            this.tABLESTableAdapter = new MetaTools.Model.DsK3CloudTableAdapters.TABLESTableAdapter();
            this.tableAdapterManager = new MetaTools.Model.DsK3CloudTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tABLESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsK3Cloud)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1186, 624);
            this.splitContainer1.SplitterDistance = 35;
            this.splitContainer1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "显示没有注释的用户表";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tABLESDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1186, 585);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户表";
            // 
            // tABLESDataGridView
            // 
            this.tABLESDataGridView.AllowUserToAddRows = false;
            this.tABLESDataGridView.AllowUserToDeleteRows = false;
            this.tABLESDataGridView.AllowUserToOrderColumns = true;
            this.tABLESDataGridView.AutoGenerateColumns = false;
            this.tABLESDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tABLESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tABLESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tABLESDataGridView.DataSource = this.tABLESBindingSource;
            this.tABLESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tABLESDataGridView.Location = new System.Drawing.Point(3, 17);
            this.tABLESDataGridView.Name = "tABLESDataGridView";
            this.tABLESDataGridView.ReadOnly = true;
            this.tABLESDataGridView.RowTemplate.Height = 23;
            this.tABLESDataGridView.Size = new System.Drawing.Size(1180, 565);
            this.tABLESDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TABLE_NAME";
            this.dataGridViewTextBoxColumn1.HeaderText = "TABLE_NAME";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TableComment";
            this.dataGridViewTextBoxColumn2.HeaderText = "TableComment";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "导出到CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTableInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 624);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmTableInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户表信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTableInfo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tABLESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsK3Cloud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Model.DsK3Cloud dsK3Cloud;
        private System.Windows.Forms.BindingSource tABLESBindingSource;
        private Model.DsK3CloudTableAdapters.TABLESTableAdapter tABLESTableAdapter;
        private Model.DsK3CloudTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tABLESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}