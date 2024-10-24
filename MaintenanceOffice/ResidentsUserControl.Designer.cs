namespace MaintenanceOffice
{
    partial class ResidentsUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.ResidentTable = new System.Windows.Forms.DataGridView();
            this.residentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceOfficeDataSet = new MaintenanceOffice.MaintenanceOfficeDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResidentSearchTextBox = new System.Windows.Forms.TextBox();
            this.ResidentSearchBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResidentFilterBtn = new System.Windows.Forms.Button();
            this.FilterResidentComboBox = new System.Windows.Forms.ComboBox();
            this.ResetResidentFilterBtn = new System.Windows.Forms.Button();
            this.AddResidentBtn = new System.Windows.Forms.Button();
            this.EditResidentBtn = new System.Windows.Forms.Button();
            this.residentTableAdapter = new MaintenanceOffice.MaintenanceOfficeDataSetTableAdapters.ResidentTableAdapter();
            this.residentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ResidentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceOfficeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Residents Table";
            // 
            // ResidentTable
            // 
            this.ResidentTable.AutoGenerateColumns = false;
            this.ResidentTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ResidentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResidentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.residentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.flatIDDataGridViewTextBoxColumn});
            this.ResidentTable.DataSource = this.residentBindingSource1;
            this.ResidentTable.Location = new System.Drawing.Point(3, 164);
            this.ResidentTable.Name = "ResidentTable";
            this.ResidentTable.Size = new System.Drawing.Size(755, 264);
            this.ResidentTable.TabIndex = 3;
            // 
            // residentIDDataGridViewTextBoxColumn
            // 
            this.residentIDDataGridViewTextBoxColumn.DataPropertyName = "ResidentID";
            this.residentIDDataGridViewTextBoxColumn.HeaderText = "ResidentID";
            this.residentIDDataGridViewTextBoxColumn.Name = "residentIDDataGridViewTextBoxColumn";
            this.residentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // flatIDDataGridViewTextBoxColumn
            // 
            this.flatIDDataGridViewTextBoxColumn.DataPropertyName = "FlatID";
            this.flatIDDataGridViewTextBoxColumn.HeaderText = "FlatID";
            this.flatIDDataGridViewTextBoxColumn.Name = "flatIDDataGridViewTextBoxColumn";
            // 
            // residentBindingSource
            // 
            this.residentBindingSource.DataMember = "Resident";
            this.residentBindingSource.DataSource = this.maintenanceOfficeDataSet;
            // 
            // maintenanceOfficeDataSet
            // 
            this.maintenanceOfficeDataSet.DataSetName = "MaintenanceOfficeDataSet";
            this.maintenanceOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ResidentSearchTextBox);
            this.groupBox1.Controls.Add(this.ResidentSearchBtn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(35, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 139);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук мешканців";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пошуковий запит:";
            // 
            // ResidentSearchTextBox
            // 
            this.ResidentSearchTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ResidentSearchTextBox.Location = new System.Drawing.Point(32, 60);
            this.ResidentSearchTextBox.Name = "ResidentSearchTextBox";
            this.ResidentSearchTextBox.Size = new System.Drawing.Size(138, 22);
            this.ResidentSearchTextBox.TabIndex = 7;
            // 
            // ResidentSearchBtn
            // 
            this.ResidentSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ResidentSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResidentSearchBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResidentSearchBtn.ForeColor = System.Drawing.Color.White;
            this.ResidentSearchBtn.Location = new System.Drawing.Point(32, 95);
            this.ResidentSearchBtn.Name = "ResidentSearchBtn";
            this.ResidentSearchBtn.Size = new System.Drawing.Size(138, 35);
            this.ResidentSearchBtn.TabIndex = 6;
            this.ResidentSearchBtn.Text = "Пошук";
            this.ResidentSearchBtn.UseVisualStyleBackColor = false;
            this.ResidentSearchBtn.Click += new System.EventHandler(this.ResidentSearchBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ResidentFilterBtn);
            this.groupBox2.Controls.Add(this.FilterResidentComboBox);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(528, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 139);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фільтрація за статусом";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Оберіть статус:";
            // 
            // ResidentFilterBtn
            // 
            this.ResidentFilterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ResidentFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResidentFilterBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResidentFilterBtn.ForeColor = System.Drawing.Color.White;
            this.ResidentFilterBtn.Location = new System.Drawing.Point(32, 95);
            this.ResidentFilterBtn.Name = "ResidentFilterBtn";
            this.ResidentFilterBtn.Size = new System.Drawing.Size(138, 35);
            this.ResidentFilterBtn.TabIndex = 6;
            this.ResidentFilterBtn.Text = "Фільтрувати";
            this.ResidentFilterBtn.UseVisualStyleBackColor = false;
            this.ResidentFilterBtn.Click += new System.EventHandler(this.ResidentFilterBtn_Click);
            // 
            // FilterResidentComboBox
            // 
            this.FilterResidentComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FilterResidentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterResidentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterResidentComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterResidentComboBox.FormattingEnabled = true;
            this.FilterResidentComboBox.Items.AddRange(new object[] {
            "Owned",
            "Rented"});
            this.FilterResidentComboBox.Location = new System.Drawing.Point(32, 57);
            this.FilterResidentComboBox.Name = "FilterResidentComboBox";
            this.FilterResidentComboBox.Size = new System.Drawing.Size(138, 25);
            this.FilterResidentComboBox.TabIndex = 7;
            // 
            // ResetResidentFilterBtn
            // 
            this.ResetResidentFilterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ResetResidentFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetResidentFilterBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetResidentFilterBtn.ForeColor = System.Drawing.Color.White;
            this.ResetResidentFilterBtn.Location = new System.Drawing.Point(314, 98);
            this.ResetResidentFilterBtn.Name = "ResetResidentFilterBtn";
            this.ResetResidentFilterBtn.Size = new System.Drawing.Size(138, 35);
            this.ResetResidentFilterBtn.TabIndex = 12;
            this.ResetResidentFilterBtn.Text = "Скинути фільтр";
            this.ResetResidentFilterBtn.UseVisualStyleBackColor = false;
            this.ResetResidentFilterBtn.Click += new System.EventHandler(this.ResetResidentFilterBtn_Click);
            // 
            // AddResidentBtn
            // 
            this.AddResidentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.AddResidentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddResidentBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddResidentBtn.ForeColor = System.Drawing.Color.White;
            this.AddResidentBtn.Location = new System.Drawing.Point(301, 3);
            this.AddResidentBtn.Name = "AddResidentBtn";
            this.AddResidentBtn.Size = new System.Drawing.Size(165, 35);
            this.AddResidentBtn.TabIndex = 13;
            this.AddResidentBtn.Text = "Додати мешканця";
            this.AddResidentBtn.UseVisualStyleBackColor = false;
            this.AddResidentBtn.Click += new System.EventHandler(this.AddResidentBtn_Click);
            // 
            // EditResidentBtn
            // 
            this.EditResidentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.EditResidentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditResidentBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditResidentBtn.ForeColor = System.Drawing.Color.White;
            this.EditResidentBtn.Location = new System.Drawing.Point(301, 50);
            this.EditResidentBtn.Name = "EditResidentBtn";
            this.EditResidentBtn.Size = new System.Drawing.Size(165, 35);
            this.EditResidentBtn.TabIndex = 14;
            this.EditResidentBtn.Text = "Змінити мешканця";
            this.EditResidentBtn.UseVisualStyleBackColor = false;
            this.EditResidentBtn.Click += new System.EventHandler(this.EditResidentBtn_Click);
            // 
            // residentTableAdapter
            // 
            this.residentTableAdapter.ClearBeforeFill = true;
            // 
            // residentBindingSource1
            // 
            this.residentBindingSource1.DataMember = "Resident";
            this.residentBindingSource1.DataSource = this.maintenanceOfficeDataSet;
            // 
            // ResidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.EditResidentBtn);
            this.Controls.Add(this.AddResidentBtn);
            this.Controls.Add(this.ResetResidentFilterBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResidentTable);
            this.Name = "ResidentsUserControl";
            this.Size = new System.Drawing.Size(761, 431);
            ((System.ComponentModel.ISupportInitialize)(this.ResidentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceOfficeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ResidentTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ResidentSearchBtn;
        private System.Windows.Forms.TextBox ResidentSearchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResidentFilterBtn;
        private System.Windows.Forms.ComboBox FilterResidentComboBox;
        private System.Windows.Forms.Button ResetResidentFilterBtn;
        private System.Windows.Forms.Button AddResidentBtn;
        private System.Windows.Forms.Button EditResidentBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource residentBindingSource;
        private MaintenanceOfficeDataSet maintenanceOfficeDataSet;
        private MaintenanceOfficeDataSetTableAdapters.ResidentTableAdapter residentTableAdapter;
        private System.Windows.Forms.BindingSource residentBindingSource1;
    }
}
