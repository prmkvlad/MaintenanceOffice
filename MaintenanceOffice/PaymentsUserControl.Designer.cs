namespace MaintenanceOffice
{
    partial class PaymentsUserControl
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
            this.PaymentTable = new System.Windows.Forms.DataGridView();
            this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentPurposeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceOfficeDataSet = new MaintenanceOffice.MaintenanceOfficeDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PaymentSearchTextBox = new System.Windows.Forms.TextBox();
            this.PaymentSearchBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentFilterByMethodBtn = new System.Windows.Forms.Button();
            this.FilterPaymentComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FilterStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.FilterEndDate = new System.Windows.Forms.DateTimePicker();
            this.PaymentFilterByDateBtn = new System.Windows.Forms.Button();
            this.AddPaymentBtn = new System.Windows.Forms.Button();
            this.ResetPaymentFilterBtn = new System.Windows.Forms.Button();
            this.paymentTableAdapter = new MaintenanceOffice.MaintenanceOfficeDataSetTableAdapters.PaymentTableAdapter();
            this.paymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceOfficeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Payments Table";
            // 
            // PaymentTable
            // 
            this.PaymentTable.AutoGenerateColumns = false;
            this.PaymentTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PaymentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentIDDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.paymentPurposeDataGridViewTextBoxColumn,
            this.residentIDDataGridViewTextBoxColumn,
            this.flatIDDataGridViewTextBoxColumn});
            this.PaymentTable.DataSource = this.paymentBindingSource;
            this.PaymentTable.Location = new System.Drawing.Point(3, 186);
            this.PaymentTable.Name = "PaymentTable";
            this.PaymentTable.Size = new System.Drawing.Size(755, 242);
            this.PaymentTable.TabIndex = 5;
            // 
            // paymentIDDataGridViewTextBoxColumn
            // 
            this.paymentIDDataGridViewTextBoxColumn.DataPropertyName = "PaymentID";
            this.paymentIDDataGridViewTextBoxColumn.HeaderText = "PaymentID";
            this.paymentIDDataGridViewTextBoxColumn.Name = "paymentIDDataGridViewTextBoxColumn";
            this.paymentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            // 
            // paymentPurposeDataGridViewTextBoxColumn
            // 
            this.paymentPurposeDataGridViewTextBoxColumn.DataPropertyName = "PaymentPurpose";
            this.paymentPurposeDataGridViewTextBoxColumn.HeaderText = "PaymentPurpose";
            this.paymentPurposeDataGridViewTextBoxColumn.Name = "paymentPurposeDataGridViewTextBoxColumn";
            // 
            // residentIDDataGridViewTextBoxColumn
            // 
            this.residentIDDataGridViewTextBoxColumn.DataPropertyName = "ResidentID";
            this.residentIDDataGridViewTextBoxColumn.HeaderText = "ResidentID";
            this.residentIDDataGridViewTextBoxColumn.Name = "residentIDDataGridViewTextBoxColumn";
            // 
            // flatIDDataGridViewTextBoxColumn
            // 
            this.flatIDDataGridViewTextBoxColumn.DataPropertyName = "FlatID";
            this.flatIDDataGridViewTextBoxColumn.HeaderText = "FlatID";
            this.flatIDDataGridViewTextBoxColumn.Name = "flatIDDataGridViewTextBoxColumn";
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.maintenanceOfficeDataSet;
            // 
            // maintenanceOfficeDataSet
            // 
            this.maintenanceOfficeDataSet.DataSetName = "MaintenanceOfficeDataSet";
            this.maintenanceOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PaymentSearchTextBox);
            this.groupBox1.Controls.Add(this.PaymentSearchBtn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 161);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук платежів";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пошуковий запит:";
            // 
            // PaymentSearchTextBox
            // 
            this.PaymentSearchTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PaymentSearchTextBox.Location = new System.Drawing.Point(27, 60);
            this.PaymentSearchTextBox.Name = "PaymentSearchTextBox";
            this.PaymentSearchTextBox.Size = new System.Drawing.Size(138, 22);
            this.PaymentSearchTextBox.TabIndex = 7;
            // 
            // PaymentSearchBtn
            // 
            this.PaymentSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PaymentSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentSearchBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentSearchBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentSearchBtn.Location = new System.Drawing.Point(27, 113);
            this.PaymentSearchBtn.Name = "PaymentSearchBtn";
            this.PaymentSearchBtn.Size = new System.Drawing.Size(138, 35);
            this.PaymentSearchBtn.TabIndex = 6;
            this.PaymentSearchBtn.Text = "Пошук";
            this.PaymentSearchBtn.UseVisualStyleBackColor = false;
            this.PaymentSearchBtn.Click += new System.EventHandler(this.PaymentSearchBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PaymentFilterByMethodBtn);
            this.groupBox2.Controls.Add(this.FilterPaymentComboBox);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(202, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 161);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фільтрація за методом оплати";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Оберіть метод:";
            // 
            // PaymentFilterByMethodBtn
            // 
            this.PaymentFilterByMethodBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PaymentFilterByMethodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentFilterByMethodBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentFilterByMethodBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentFilterByMethodBtn.Location = new System.Drawing.Point(32, 113);
            this.PaymentFilterByMethodBtn.Name = "PaymentFilterByMethodBtn";
            this.PaymentFilterByMethodBtn.Size = new System.Drawing.Size(138, 35);
            this.PaymentFilterByMethodBtn.TabIndex = 6;
            this.PaymentFilterByMethodBtn.Text = "Фільтрувати";
            this.PaymentFilterByMethodBtn.UseVisualStyleBackColor = false;
            this.PaymentFilterByMethodBtn.Click += new System.EventHandler(this.PaymentFilterByTypeBtn_Click);
            // 
            // FilterPaymentComboBox
            // 
            this.FilterPaymentComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FilterPaymentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterPaymentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterPaymentComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterPaymentComboBox.FormattingEnabled = true;
            this.FilterPaymentComboBox.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Bank Transfer"});
            this.FilterPaymentComboBox.Location = new System.Drawing.Point(32, 57);
            this.FilterPaymentComboBox.Name = "FilterPaymentComboBox";
            this.FilterPaymentComboBox.Size = new System.Drawing.Size(138, 25);
            this.FilterPaymentComboBox.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.FilterStartDate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.FilterEndDate);
            this.groupBox3.Controls.Add(this.PaymentFilterByDateBtn);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(415, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 161);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фільтрація за датою";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата від:";
            // 
            // FilterStartDate
            // 
            this.FilterStartDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.FilterStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterStartDate.Location = new System.Drawing.Point(26, 40);
            this.FilterStartDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.FilterStartDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.FilterStartDate.Name = "FilterStartDate";
            this.FilterStartDate.Size = new System.Drawing.Size(138, 22);
            this.FilterStartDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата до:";
            // 
            // FilterEndDate
            // 
            this.FilterEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterEndDate.Location = new System.Drawing.Point(26, 85);
            this.FilterEndDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.FilterEndDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.FilterEndDate.Name = "FilterEndDate";
            this.FilterEndDate.Size = new System.Drawing.Size(138, 22);
            this.FilterEndDate.TabIndex = 7;
            // 
            // PaymentFilterByDateBtn
            // 
            this.PaymentFilterByDateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PaymentFilterByDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentFilterByDateBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentFilterByDateBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentFilterByDateBtn.Location = new System.Drawing.Point(26, 113);
            this.PaymentFilterByDateBtn.Name = "PaymentFilterByDateBtn";
            this.PaymentFilterByDateBtn.Size = new System.Drawing.Size(138, 35);
            this.PaymentFilterByDateBtn.TabIndex = 6;
            this.PaymentFilterByDateBtn.Text = "Фільтрувати";
            this.PaymentFilterByDateBtn.UseVisualStyleBackColor = false;
            this.PaymentFilterByDateBtn.Click += new System.EventHandler(this.PaymentFilterByDateBtn_Click);
            // 
            // AddPaymentBtn
            // 
            this.AddPaymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.AddPaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPaymentBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPaymentBtn.ForeColor = System.Drawing.Color.White;
            this.AddPaymentBtn.Location = new System.Drawing.Point(614, 48);
            this.AddPaymentBtn.Name = "AddPaymentBtn";
            this.AddPaymentBtn.Size = new System.Drawing.Size(138, 35);
            this.AddPaymentBtn.TabIndex = 14;
            this.AddPaymentBtn.Text = "Додати платіж";
            this.AddPaymentBtn.UseVisualStyleBackColor = false;
            this.AddPaymentBtn.Click += new System.EventHandler(this.AddPaymentBtn_Click);
            // 
            // ResetPaymentFilterBtn
            // 
            this.ResetPaymentFilterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ResetPaymentFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetPaymentFilterBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetPaymentFilterBtn.ForeColor = System.Drawing.Color.White;
            this.ResetPaymentFilterBtn.Location = new System.Drawing.Point(614, 89);
            this.ResetPaymentFilterBtn.Name = "ResetPaymentFilterBtn";
            this.ResetPaymentFilterBtn.Size = new System.Drawing.Size(138, 35);
            this.ResetPaymentFilterBtn.TabIndex = 15;
            this.ResetPaymentFilterBtn.Text = "Скинути фільтр";
            this.ResetPaymentFilterBtn.UseVisualStyleBackColor = false;
            this.ResetPaymentFilterBtn.Click += new System.EventHandler(this.ResetPaymentFilterBtn_Click);
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // paymentBindingSource1
            // 
            this.paymentBindingSource1.DataMember = "Payment";
            this.paymentBindingSource1.DataSource = this.maintenanceOfficeDataSet;
            // 
            // PaymentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ResetPaymentFilterBtn);
            this.Controls.Add(this.AddPaymentBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaymentTable);
            this.Name = "PaymentsUserControl";
            this.Size = new System.Drawing.Size(761, 431);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceOfficeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PaymentTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PaymentSearchTextBox;
        private System.Windows.Forms.Button PaymentSearchBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PaymentFilterByMethodBtn;
        private System.Windows.Forms.ComboBox FilterPaymentComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PaymentFilterByDateBtn;
        private System.Windows.Forms.Button AddPaymentBtn;
        private System.Windows.Forms.Button ResetPaymentFilterBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FilterEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FilterStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentPurposeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private MaintenanceOfficeDataSet maintenanceOfficeDataSet;
        private MaintenanceOfficeDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.BindingSource paymentBindingSource1;
    }
}
