namespace MaintenanceOffice
{
    partial class AccountingOfBuildingsUserControl
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
            this.HouseTable = new System.Windows.Forms.DataGridView();
            this.houseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfFloorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfFlatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicalConditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsiblePersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceOfficeDataSet = new MaintenanceOffice.MaintenanceOfficeDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.FlatTable = new System.Windows.Forms.DataGridView();
            this.flatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HouseTechStatusComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateHouseStatusBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HouseSearchTextBox = new System.Windows.Forms.TextBox();
            this.HouseSearchBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SelectedHouseTextArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowFlatsBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SortFlatByComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SortFlatBtn = new System.Windows.Forms.Button();
            this.houseTableAdapter = new MaintenanceOffice.MaintenanceOfficeDataSetTableAdapters.HouseTableAdapter();
            this.flatTableAdapter = new MaintenanceOffice.MaintenanceOfficeDataSetTableAdapters.FlatTableAdapter();
            this.houseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HouseTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceOfficeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlatTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Houses Table";
            // 
            // HouseTable
            // 
            this.HouseTable.AutoGenerateColumns = false;
            this.HouseTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.HouseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HouseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.houseIDDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.numberOfFloorsDataGridViewTextBoxColumn,
            this.numberOfFlatsDataGridViewTextBoxColumn,
            this.technicalConditionDataGridViewTextBoxColumn,
            this.responsiblePersonDataGridViewTextBoxColumn});
            this.HouseTable.DataSource = this.houseBindingSource1;
            this.HouseTable.Location = new System.Drawing.Point(3, 164);
            this.HouseTable.Name = "HouseTable";
            this.HouseTable.Size = new System.Drawing.Size(375, 264);
            this.HouseTable.TabIndex = 7;
            // 
            // houseIDDataGridViewTextBoxColumn
            // 
            this.houseIDDataGridViewTextBoxColumn.DataPropertyName = "HouseID";
            this.houseIDDataGridViewTextBoxColumn.HeaderText = "HouseID";
            this.houseIDDataGridViewTextBoxColumn.Name = "houseIDDataGridViewTextBoxColumn";
            this.houseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // numberOfFloorsDataGridViewTextBoxColumn
            // 
            this.numberOfFloorsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfFloors";
            this.numberOfFloorsDataGridViewTextBoxColumn.HeaderText = "NumberOfFloors";
            this.numberOfFloorsDataGridViewTextBoxColumn.Name = "numberOfFloorsDataGridViewTextBoxColumn";
            // 
            // numberOfFlatsDataGridViewTextBoxColumn
            // 
            this.numberOfFlatsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfFlats";
            this.numberOfFlatsDataGridViewTextBoxColumn.HeaderText = "NumberOfFlats";
            this.numberOfFlatsDataGridViewTextBoxColumn.Name = "numberOfFlatsDataGridViewTextBoxColumn";
            // 
            // technicalConditionDataGridViewTextBoxColumn
            // 
            this.technicalConditionDataGridViewTextBoxColumn.DataPropertyName = "TechnicalCondition";
            this.technicalConditionDataGridViewTextBoxColumn.HeaderText = "TechnicalCondition";
            this.technicalConditionDataGridViewTextBoxColumn.Name = "technicalConditionDataGridViewTextBoxColumn";
            // 
            // responsiblePersonDataGridViewTextBoxColumn
            // 
            this.responsiblePersonDataGridViewTextBoxColumn.DataPropertyName = "ResponsiblePerson";
            this.responsiblePersonDataGridViewTextBoxColumn.HeaderText = "ResponsiblePerson";
            this.responsiblePersonDataGridViewTextBoxColumn.Name = "responsiblePersonDataGridViewTextBoxColumn";
            // 
            // houseBindingSource
            // 
            this.houseBindingSource.DataMember = "House";
            this.houseBindingSource.DataSource = this.maintenanceOfficeDataSet;
            // 
            // maintenanceOfficeDataSet
            // 
            this.maintenanceOfficeDataSet.DataSetName = "MaintenanceOfficeDataSet";
            this.maintenanceOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(381, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Flats Table";
            // 
            // FlatTable
            // 
            this.FlatTable.AutoGenerateColumns = false;
            this.FlatTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.FlatTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlatTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flatIDDataGridViewTextBoxColumn,
            this.flatNumberDataGridViewTextBoxColumn,
            this.flatAreaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.houseIDDataGridViewTextBoxColumn1});
            this.FlatTable.DataSource = this.flatBindingSource1;
            this.FlatTable.Location = new System.Drawing.Point(384, 164);
            this.FlatTable.Name = "FlatTable";
            this.FlatTable.Size = new System.Drawing.Size(375, 264);
            this.FlatTable.TabIndex = 9;
            // 
            // flatIDDataGridViewTextBoxColumn
            // 
            this.flatIDDataGridViewTextBoxColumn.DataPropertyName = "FlatID";
            this.flatIDDataGridViewTextBoxColumn.HeaderText = "FlatID";
            this.flatIDDataGridViewTextBoxColumn.Name = "flatIDDataGridViewTextBoxColumn";
            this.flatIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flatNumberDataGridViewTextBoxColumn
            // 
            this.flatNumberDataGridViewTextBoxColumn.DataPropertyName = "FlatNumber";
            this.flatNumberDataGridViewTextBoxColumn.HeaderText = "FlatNumber";
            this.flatNumberDataGridViewTextBoxColumn.Name = "flatNumberDataGridViewTextBoxColumn";
            // 
            // flatAreaDataGridViewTextBoxColumn
            // 
            this.flatAreaDataGridViewTextBoxColumn.DataPropertyName = "FlatArea";
            this.flatAreaDataGridViewTextBoxColumn.HeaderText = "FlatArea";
            this.flatAreaDataGridViewTextBoxColumn.Name = "flatAreaDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // houseIDDataGridViewTextBoxColumn1
            // 
            this.houseIDDataGridViewTextBoxColumn1.DataPropertyName = "HouseID";
            this.houseIDDataGridViewTextBoxColumn1.HeaderText = "HouseID";
            this.houseIDDataGridViewTextBoxColumn1.Name = "houseIDDataGridViewTextBoxColumn1";
            // 
            // flatBindingSource
            // 
            this.flatBindingSource.DataMember = "Flat";
            this.flatBindingSource.DataSource = this.maintenanceOfficeDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HouseTechStatusComboBox);
            this.groupBox2.Controls.Add(this.UpdateHouseStatusBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(163, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 139);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Зміна технічного стану будинку";
            // 
            // HouseTechStatusComboBox
            // 
            this.HouseTechStatusComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HouseTechStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HouseTechStatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HouseTechStatusComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseTechStatusComboBox.FormattingEnabled = true;
            this.HouseTechStatusComboBox.Items.AddRange(new object[] {
            "Good",
            "Fair",
            "Excellent",
            "Needs Repair"});
            this.HouseTechStatusComboBox.Location = new System.Drawing.Point(38, 57);
            this.HouseTechStatusComboBox.Name = "HouseTechStatusComboBox";
            this.HouseTechStatusComboBox.Size = new System.Drawing.Size(138, 25);
            this.HouseTechStatusComboBox.TabIndex = 4;
            // 
            // UpdateHouseStatusBtn
            // 
            this.UpdateHouseStatusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.UpdateHouseStatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateHouseStatusBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateHouseStatusBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateHouseStatusBtn.Location = new System.Drawing.Point(38, 95);
            this.UpdateHouseStatusBtn.Name = "UpdateHouseStatusBtn";
            this.UpdateHouseStatusBtn.Size = new System.Drawing.Size(138, 35);
            this.UpdateHouseStatusBtn.TabIndex = 3;
            this.UpdateHouseStatusBtn.Text = "Оновити стан";
            this.UpdateHouseStatusBtn.UseVisualStyleBackColor = false;
            this.UpdateHouseStatusBtn.Click += new System.EventHandler(this.UpdateHouseStatusBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Оберіть стан:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.HouseSearchTextBox);
            this.groupBox1.Controls.Add(this.HouseSearchBtn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 139);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук будинків";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пошуковий запит:";
            // 
            // HouseSearchTextBox
            // 
            this.HouseSearchTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.HouseSearchTextBox.Location = new System.Drawing.Point(6, 60);
            this.HouseSearchTextBox.Name = "HouseSearchTextBox";
            this.HouseSearchTextBox.Size = new System.Drawing.Size(138, 22);
            this.HouseSearchTextBox.TabIndex = 7;
            // 
            // HouseSearchBtn
            // 
            this.HouseSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.HouseSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HouseSearchBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseSearchBtn.ForeColor = System.Drawing.Color.White;
            this.HouseSearchBtn.Location = new System.Drawing.Point(6, 95);
            this.HouseSearchBtn.Name = "HouseSearchBtn";
            this.HouseSearchBtn.Size = new System.Drawing.Size(138, 35);
            this.HouseSearchBtn.TabIndex = 6;
            this.HouseSearchBtn.Text = "Пошук";
            this.HouseSearchBtn.UseVisualStyleBackColor = false;
            this.HouseSearchBtn.Click += new System.EventHandler(this.HouseSearchBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SelectedHouseTextArea);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ShowFlatsBtn);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(384, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 139);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Перелік квартир у будинку";
            // 
            // SelectedHouseTextArea
            // 
            this.SelectedHouseTextArea.BackColor = System.Drawing.SystemColors.Control;
            this.SelectedHouseTextArea.Location = new System.Drawing.Point(32, 57);
            this.SelectedHouseTextArea.Name = "SelectedHouseTextArea";
            this.SelectedHouseTextArea.Size = new System.Drawing.Size(138, 22);
            this.SelectedHouseTextArea.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введіть ID будинку:";
            // 
            // ShowFlatsBtn
            // 
            this.ShowFlatsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ShowFlatsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowFlatsBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowFlatsBtn.ForeColor = System.Drawing.Color.White;
            this.ShowFlatsBtn.Location = new System.Drawing.Point(32, 95);
            this.ShowFlatsBtn.Name = "ShowFlatsBtn";
            this.ShowFlatsBtn.Size = new System.Drawing.Size(138, 35);
            this.ShowFlatsBtn.TabIndex = 6;
            this.ShowFlatsBtn.Text = "Показати";
            this.ShowFlatsBtn.UseVisualStyleBackColor = false;
            this.ShowFlatsBtn.Click += new System.EventHandler(this.ShowFlatsBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SortFlatByComboBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.SortFlatBtn);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(590, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 139);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Сортування квартир";
            // 
            // SortFlatByComboBox
            // 
            this.SortFlatByComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SortFlatByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortFlatByComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortFlatByComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortFlatByComboBox.FormattingEnabled = true;
            this.SortFlatByComboBox.Items.AddRange(new object[] {
            "FlatID",
            "FlatNumber",
            "FlatArea",
            "Status"});
            this.SortFlatByComboBox.Location = new System.Drawing.Point(15, 57);
            this.SortFlatByComboBox.Name = "SortFlatByComboBox";
            this.SortFlatByComboBox.Size = new System.Drawing.Size(138, 25);
            this.SortFlatByComboBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Сортувати за:";
            // 
            // SortFlatBtn
            // 
            this.SortFlatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SortFlatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortFlatBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortFlatBtn.ForeColor = System.Drawing.Color.White;
            this.SortFlatBtn.Location = new System.Drawing.Point(15, 95);
            this.SortFlatBtn.Name = "SortFlatBtn";
            this.SortFlatBtn.Size = new System.Drawing.Size(138, 35);
            this.SortFlatBtn.TabIndex = 6;
            this.SortFlatBtn.Text = "Сортувати";
            this.SortFlatBtn.UseVisualStyleBackColor = false;
            this.SortFlatBtn.Click += new System.EventHandler(this.SortFlatBtn_Click);
            // 
            // houseTableAdapter
            // 
            this.houseTableAdapter.ClearBeforeFill = true;
            // 
            // flatTableAdapter
            // 
            this.flatTableAdapter.ClearBeforeFill = true;
            // 
            // houseBindingSource1
            // 
            this.houseBindingSource1.DataMember = "House";
            this.houseBindingSource1.DataSource = this.maintenanceOfficeDataSet;
            // 
            // flatBindingSource1
            // 
            this.flatBindingSource1.DataMember = "Flat";
            this.flatBindingSource1.DataSource = this.maintenanceOfficeDataSet;
            // 
            // AccountingOfBuildingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FlatTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HouseTable);
            this.Name = "AccountingOfBuildingsUserControl";
            this.Size = new System.Drawing.Size(761, 431);
            ((System.ComponentModel.ISupportInitialize)(this.HouseTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceOfficeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlatTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView HouseTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView FlatTable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox HouseTechStatusComboBox;
        private System.Windows.Forms.Button UpdateHouseStatusBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HouseSearchTextBox;
        private System.Windows.Forms.Button HouseSearchBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ShowFlatsBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox SortFlatByComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SortFlatBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfFloorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfFlatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicalConditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsiblePersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource houseBindingSource;
        private MaintenanceOfficeDataSet maintenanceOfficeDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource flatBindingSource;
        private MaintenanceOfficeDataSetTableAdapters.HouseTableAdapter houseTableAdapter;
        private MaintenanceOfficeDataSetTableAdapters.FlatTableAdapter flatTableAdapter;
        private System.Windows.Forms.TextBox SelectedHouseTextArea;
        private System.Windows.Forms.BindingSource houseBindingSource1;
        private System.Windows.Forms.BindingSource flatBindingSource1;
    }
}
