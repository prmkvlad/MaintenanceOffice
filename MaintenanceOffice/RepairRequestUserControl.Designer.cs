namespace MaintenanceOffice
{
    partial class RepairRequestUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RepairRequestTable = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceOfficeDataSet = new MaintenanceOffice.MaintenanceOfficeDataSet();
            this.AddRepairRequestBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateRepairRequestBtn = new System.Windows.Forms.Button();
            this.UpdateRepairRequestStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterRepairRequestBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterRepairStatusComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResetRepairRequestFilterBtn = new System.Windows.Forms.Button();
            this.repairRequestTableAdapter = new MaintenanceOffice.MaintenanceOfficeDataSetTableAdapters.RepairRequestTableAdapter();
            this.repairRequestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RepairRequestTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceOfficeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repairRequestBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // RepairRequestTable
            // 
            this.RepairRequestTable.AutoGenerateColumns = false;
            this.RepairRequestTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.RepairRequestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RepairRequestTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.repairTypeDataGridViewTextBoxColumn,
            this.submissionDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.assignedEmployeeDataGridViewTextBoxColumn,
            this.flatIDDataGridViewTextBoxColumn});
            this.RepairRequestTable.DataSource = this.repairRequestBindingSource1;
            this.RepairRequestTable.Location = new System.Drawing.Point(3, 164);
            this.RepairRequestTable.Name = "RepairRequestTable";
            this.RepairRequestTable.Size = new System.Drawing.Size(755, 264);
            this.RepairRequestTable.TabIndex = 0;
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repairTypeDataGridViewTextBoxColumn
            // 
            this.repairTypeDataGridViewTextBoxColumn.DataPropertyName = "RepairType";
            this.repairTypeDataGridViewTextBoxColumn.HeaderText = "RepairType";
            this.repairTypeDataGridViewTextBoxColumn.Name = "repairTypeDataGridViewTextBoxColumn";
            // 
            // submissionDateDataGridViewTextBoxColumn
            // 
            this.submissionDateDataGridViewTextBoxColumn.DataPropertyName = "SubmissionDate";
            this.submissionDateDataGridViewTextBoxColumn.HeaderText = "SubmissionDate";
            this.submissionDateDataGridViewTextBoxColumn.Name = "submissionDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // assignedEmployeeDataGridViewTextBoxColumn
            // 
            this.assignedEmployeeDataGridViewTextBoxColumn.DataPropertyName = "AssignedEmployee";
            this.assignedEmployeeDataGridViewTextBoxColumn.HeaderText = "AssignedEmployee";
            this.assignedEmployeeDataGridViewTextBoxColumn.Name = "assignedEmployeeDataGridViewTextBoxColumn";
            // 
            // flatIDDataGridViewTextBoxColumn
            // 
            this.flatIDDataGridViewTextBoxColumn.DataPropertyName = "FlatID";
            this.flatIDDataGridViewTextBoxColumn.HeaderText = "FlatID";
            this.flatIDDataGridViewTextBoxColumn.Name = "flatIDDataGridViewTextBoxColumn";
            // 
            // repairRequestBindingSource
            // 
            this.repairRequestBindingSource.DataMember = "RepairRequest";
            this.repairRequestBindingSource.DataSource = this.maintenanceOfficeDataSet;
            // 
            // maintenanceOfficeDataSet
            // 
            this.maintenanceOfficeDataSet.DataSetName = "MaintenanceOfficeDataSet";
            this.maintenanceOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddRepairRequestBtn
            // 
            this.AddRepairRequestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.AddRepairRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRepairRequestBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRepairRequestBtn.ForeColor = System.Drawing.Color.White;
            this.AddRepairRequestBtn.Location = new System.Drawing.Point(313, 50);
            this.AddRepairRequestBtn.Name = "AddRepairRequestBtn";
            this.AddRepairRequestBtn.Size = new System.Drawing.Size(138, 35);
            this.AddRepairRequestBtn.TabIndex = 1;
            this.AddRepairRequestBtn.Text = "Додати заяву";
            this.AddRepairRequestBtn.UseVisualStyleBackColor = false;
            this.AddRepairRequestBtn.Click += new System.EventHandler(this.AddRepairRequestBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "RepairRequest Table";
            // 
            // UpdateRepairRequestBtn
            // 
            this.UpdateRepairRequestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.UpdateRepairRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateRepairRequestBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateRepairRequestBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateRepairRequestBtn.Location = new System.Drawing.Point(34, 95);
            this.UpdateRepairRequestBtn.Name = "UpdateRepairRequestBtn";
            this.UpdateRepairRequestBtn.Size = new System.Drawing.Size(138, 35);
            this.UpdateRepairRequestBtn.TabIndex = 3;
            this.UpdateRepairRequestBtn.Text = "Оновити статус";
            this.UpdateRepairRequestBtn.UseVisualStyleBackColor = false;
            this.UpdateRepairRequestBtn.Click += new System.EventHandler(this.UpdateRepairRequestBtn_Click);
            // 
            // UpdateRepairRequestStatusComboBox
            // 
            this.UpdateRepairRequestStatusComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UpdateRepairRequestStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateRepairRequestStatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateRepairRequestStatusComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateRepairRequestStatusComboBox.FormattingEnabled = true;
            this.UpdateRepairRequestStatusComboBox.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Completed"});
            this.UpdateRepairRequestStatusComboBox.Location = new System.Drawing.Point(34, 57);
            this.UpdateRepairRequestStatusComboBox.Name = "UpdateRepairRequestStatusComboBox";
            this.UpdateRepairRequestStatusComboBox.Size = new System.Drawing.Size(138, 25);
            this.UpdateRepairRequestStatusComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Оберіть статус:";
            // 
            // FilterRepairRequestBtn
            // 
            this.FilterRepairRequestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.FilterRepairRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterRepairRequestBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterRepairRequestBtn.ForeColor = System.Drawing.Color.White;
            this.FilterRepairRequestBtn.Location = new System.Drawing.Point(32, 95);
            this.FilterRepairRequestBtn.Name = "FilterRepairRequestBtn";
            this.FilterRepairRequestBtn.Size = new System.Drawing.Size(138, 35);
            this.FilterRepairRequestBtn.TabIndex = 6;
            this.FilterRepairRequestBtn.Text = "Фільтрувати";
            this.FilterRepairRequestBtn.UseVisualStyleBackColor = false;
            this.FilterRepairRequestBtn.Click += new System.EventHandler(this.FilterRepairRequestBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Оберіть статус:";
            // 
            // FilterRepairStatusComboBox
            // 
            this.FilterRepairStatusComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FilterRepairStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterRepairStatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterRepairStatusComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterRepairStatusComboBox.FormattingEnabled = true;
            this.FilterRepairStatusComboBox.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Completed"});
            this.FilterRepairStatusComboBox.Location = new System.Drawing.Point(32, 57);
            this.FilterRepairStatusComboBox.Name = "FilterRepairStatusComboBox";
            this.FilterRepairStatusComboBox.Size = new System.Drawing.Size(138, 25);
            this.FilterRepairStatusComboBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FilterRepairRequestBtn);
            this.groupBox1.Controls.Add(this.FilterRepairStatusComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(33, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 139);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фільтрація заяв за статусом";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdateRepairRequestStatusComboBox);
            this.groupBox2.Controls.Add(this.UpdateRepairRequestBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(528, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 139);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оновлення статусу заяви";
            // 
            // ResetRepairRequestFilterBtn
            // 
            this.ResetRepairRequestFilterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ResetRepairRequestFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetRepairRequestFilterBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetRepairRequestFilterBtn.ForeColor = System.Drawing.Color.White;
            this.ResetRepairRequestFilterBtn.Location = new System.Drawing.Point(313, 98);
            this.ResetRepairRequestFilterBtn.Name = "ResetRepairRequestFilterBtn";
            this.ResetRepairRequestFilterBtn.Size = new System.Drawing.Size(138, 35);
            this.ResetRepairRequestFilterBtn.TabIndex = 11;
            this.ResetRepairRequestFilterBtn.Text = "Скинути фільтр";
            this.ResetRepairRequestFilterBtn.UseVisualStyleBackColor = false;
            this.ResetRepairRequestFilterBtn.Click += new System.EventHandler(this.ResetRepairRequestFilterBtn_Click);
            // 
            // repairRequestTableAdapter
            // 
            this.repairRequestTableAdapter.ClearBeforeFill = true;
            // 
            // repairRequestBindingSource1
            // 
            this.repairRequestBindingSource1.DataMember = "RepairRequest";
            this.repairRequestBindingSource1.DataSource = this.maintenanceOfficeDataSet;
            // 
            // RepairRequestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ResetRepairRequestFilterBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddRepairRequestBtn);
            this.Controls.Add(this.RepairRequestTable);
            this.Name = "RepairRequestUserControl";
            this.Size = new System.Drawing.Size(761, 431);
            ((System.ComponentModel.ISupportInitialize)(this.RepairRequestTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceOfficeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repairRequestBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RepairRequestTable;
        private System.Windows.Forms.Button AddRepairRequestBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateRepairRequestBtn;
        private System.Windows.Forms.ComboBox UpdateRepairRequestStatusComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FilterRepairRequestBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FilterRepairStatusComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ResetRepairRequestFilterBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submissionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource repairRequestBindingSource;
        private MaintenanceOfficeDataSet maintenanceOfficeDataSet;
        private MaintenanceOfficeDataSetTableAdapters.RepairRequestTableAdapter repairRequestTableAdapter;
        private System.Windows.Forms.BindingSource repairRequestBindingSource1;
    }
}
