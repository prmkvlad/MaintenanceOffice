namespace MaintenanceOffice
{
    partial class UtilitiesUserControl
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
            this.UtilitiesTable = new System.Windows.Forms.DataGridView();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilityServiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceOfficeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceOfficeDataSet = new MaintenanceOffice.MaintenanceOfficeDataSet();
            this.utilityServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddServiceBtn = new System.Windows.Forms.Button();
            this.EditServiceBtn = new System.Windows.Forms.Button();
            this.DeleteServiceBtn = new System.Windows.Forms.Button();
            this.utilityServiceTableAdapter = new MaintenanceOffice.MaintenanceOfficeDataSetTableAdapters.UtilityServiceTableAdapter();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new MaintenanceOffice.MaintenanceOfficeDataSetTableAdapters.PaymentTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewTarifTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UtilitiesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilityServiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceOfficeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceOfficeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilityServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Utilities Table";
            // 
            // UtilitiesTable
            // 
            this.UtilitiesTable.AutoGenerateColumns = false;
            this.UtilitiesTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.UtilitiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UtilitiesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.tariffDataGridViewTextBoxColumn,
            this.houseIDDataGridViewTextBoxColumn});
            this.UtilitiesTable.DataSource = this.utilityServiceBindingSource1;
            this.UtilitiesTable.Location = new System.Drawing.Point(3, 164);
            this.UtilitiesTable.Name = "UtilitiesTable";
            this.UtilitiesTable.Size = new System.Drawing.Size(755, 264);
            this.UtilitiesTable.TabIndex = 5;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            // 
            // tariffDataGridViewTextBoxColumn
            // 
            this.tariffDataGridViewTextBoxColumn.DataPropertyName = "Tariff";
            this.tariffDataGridViewTextBoxColumn.HeaderText = "Tariff";
            this.tariffDataGridViewTextBoxColumn.Name = "tariffDataGridViewTextBoxColumn";
            // 
            // houseIDDataGridViewTextBoxColumn
            // 
            this.houseIDDataGridViewTextBoxColumn.DataPropertyName = "HouseID";
            this.houseIDDataGridViewTextBoxColumn.HeaderText = "HouseID";
            this.houseIDDataGridViewTextBoxColumn.Name = "houseIDDataGridViewTextBoxColumn";
            // 
            // utilityServiceBindingSource1
            // 
            this.utilityServiceBindingSource1.DataMember = "UtilityService";
            this.utilityServiceBindingSource1.DataSource = this.maintenanceOfficeDataSetBindingSource;
            // 
            // maintenanceOfficeDataSetBindingSource
            // 
            this.maintenanceOfficeDataSetBindingSource.DataSource = this.maintenanceOfficeDataSet;
            this.maintenanceOfficeDataSetBindingSource.Position = 0;
            // 
            // maintenanceOfficeDataSet
            // 
            this.maintenanceOfficeDataSet.DataSetName = "MaintenanceOfficeDataSet";
            this.maintenanceOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilityServiceBindingSource
            // 
            this.utilityServiceBindingSource.DataMember = "UtilityService";
            this.utilityServiceBindingSource.DataSource = this.maintenanceOfficeDataSet;
            // 
            // AddServiceBtn
            // 
            this.AddServiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.AddServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddServiceBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddServiceBtn.ForeColor = System.Drawing.Color.White;
            this.AddServiceBtn.Location = new System.Drawing.Point(96, 65);
            this.AddServiceBtn.Name = "AddServiceBtn";
            this.AddServiceBtn.Size = new System.Drawing.Size(153, 35);
            this.AddServiceBtn.TabIndex = 15;
            this.AddServiceBtn.Text = "Додати послугу";
            this.AddServiceBtn.UseVisualStyleBackColor = false;
            this.AddServiceBtn.Click += new System.EventHandler(this.AddServiceBtn_Click);
            // 
            // EditServiceBtn
            // 
            this.EditServiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.EditServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditServiceBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditServiceBtn.ForeColor = System.Drawing.Color.White;
            this.EditServiceBtn.Location = new System.Drawing.Point(24, 98);
            this.EditServiceBtn.Name = "EditServiceBtn";
            this.EditServiceBtn.Size = new System.Drawing.Size(153, 35);
            this.EditServiceBtn.TabIndex = 16;
            this.EditServiceBtn.Text = "Змінити тариф";
            this.EditServiceBtn.UseVisualStyleBackColor = false;
            this.EditServiceBtn.Click += new System.EventHandler(this.EditServiceBtn_Click);
            // 
            // DeleteServiceBtn
            // 
            this.DeleteServiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.DeleteServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteServiceBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteServiceBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteServiceBtn.Location = new System.Drawing.Point(527, 65);
            this.DeleteServiceBtn.Name = "DeleteServiceBtn";
            this.DeleteServiceBtn.Size = new System.Drawing.Size(153, 35);
            this.DeleteServiceBtn.TabIndex = 17;
            this.DeleteServiceBtn.Text = "Видалити послугу";
            this.DeleteServiceBtn.UseVisualStyleBackColor = false;
            this.DeleteServiceBtn.Click += new System.EventHandler(this.DeleteServiceBtn_Click);
            // 
            // utilityServiceTableAdapter
            // 
            this.utilityServiceTableAdapter.ClearBeforeFill = true;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.maintenanceOfficeDataSetBindingSource;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewTarifTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EditServiceBtn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(289, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 139);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Зміна тарифу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введіть нове значення:";
            // 
            // NewTarifTextBox
            // 
            this.NewTarifTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.NewTarifTextBox.Location = new System.Drawing.Point(32, 58);
            this.NewTarifTextBox.Name = "NewTarifTextBox";
            this.NewTarifTextBox.Size = new System.Drawing.Size(139, 22);
            this.NewTarifTextBox.TabIndex = 75;
            // 
            // UtilitiesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteServiceBtn);
            this.Controls.Add(this.AddServiceBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UtilitiesTable);
            this.Name = "UtilitiesUserControl";
            this.Size = new System.Drawing.Size(761, 431);
            ((System.ComponentModel.ISupportInitialize)(this.UtilitiesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilityServiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceOfficeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceOfficeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilityServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UtilitiesTable;
        private System.Windows.Forms.Button AddServiceBtn;
        private System.Windows.Forms.Button EditServiceBtn;
        private System.Windows.Forms.Button DeleteServiceBtn;
        private System.Windows.Forms.BindingSource utilityServiceBindingSource;
        private MaintenanceOfficeDataSet maintenanceOfficeDataSet;
        private MaintenanceOfficeDataSetTableAdapters.UtilityServiceTableAdapter utilityServiceTableAdapter;
        private System.Windows.Forms.BindingSource maintenanceOfficeDataSetBindingSource;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private MaintenanceOfficeDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource utilityServiceBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewTarifTextBox;
    }
}
