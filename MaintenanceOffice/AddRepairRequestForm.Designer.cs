namespace MaintenanceOffice
{
    partial class AddRepairRequestForm
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
            this.AssignedEmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmissionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RepairTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.FlatComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AssignedEmployeeComboBox
            // 
            this.AssignedEmployeeComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AssignedEmployeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssignedEmployeeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignedEmployeeComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AssignedEmployeeComboBox.FormattingEnabled = true;
            this.AssignedEmployeeComboBox.Items.AddRange(new object[] {
            "Rent",
            "Utilities"});
            this.AssignedEmployeeComboBox.Location = new System.Drawing.Point(14, 136);
            this.AssignedEmployeeComboBox.Name = "AssignedEmployeeComboBox";
            this.AssignedEmployeeComboBox.Size = new System.Drawing.Size(120, 25);
            this.AssignedEmployeeComboBox.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Виконавець";
            // 
            // SubmissionDatePicker
            // 
            this.SubmissionDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.SubmissionDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SubmissionDatePicker.Location = new System.Drawing.Point(12, 87);
            this.SubmissionDatePicker.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.SubmissionDatePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.SubmissionDatePicker.Name = "SubmissionDatePicker";
            this.SubmissionDatePicker.Size = new System.Drawing.Size(122, 20);
            this.SubmissionDatePicker.TabIndex = 53;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(83, 212);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(138, 35);
            this.CancelBtn.TabIndex = 51;
            this.CancelBtn.Text = "Скасувати";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(83, 167);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(138, 35);
            this.SaveBtn.TabIndex = 50;
            this.SaveBtn.Text = "Зберегти";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Completed"});
            this.StatusComboBox.Location = new System.Drawing.Point(170, 32);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(120, 25);
            this.StatusComboBox.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(170, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Опис";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Дата подання";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(167, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Статус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Тип ремонту";
            // 
            // RepairTypeComboBox
            // 
            this.RepairTypeComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RepairTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RepairTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepairTypeComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepairTypeComboBox.FormattingEnabled = true;
            this.RepairTypeComboBox.Items.AddRange(new object[] {
            "Plumbing",
            "Electrical",
            "General",
            "Heating"});
            this.RepairTypeComboBox.Location = new System.Drawing.Point(14, 32);
            this.RepairTypeComboBox.Name = "RepairTypeComboBox";
            this.RepairTypeComboBox.Size = new System.Drawing.Size(120, 25);
            this.RepairTypeComboBox.TabIndex = 56;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DescriptionTextBox.Location = new System.Drawing.Point(170, 87);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(120, 20);
            this.DescriptionTextBox.TabIndex = 57;
            // 
            // FlatComboBox
            // 
            this.FlatComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FlatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlatComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlatComboBox.FormattingEnabled = true;
            this.FlatComboBox.Items.AddRange(new object[] {
            "Rent",
            "Utilities"});
            this.FlatComboBox.Location = new System.Drawing.Point(170, 136);
            this.FlatComboBox.Name = "FlatComboBox";
            this.FlatComboBox.Size = new System.Drawing.Size(120, 25);
            this.FlatComboBox.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(167, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Квартира";
            // 
            // AddRepairRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.FlatComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.RepairTypeComboBox);
            this.Controls.Add(this.AssignedEmployeeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmissionDatePicker);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRepairRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRepairRequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AssignedEmployeeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker SubmissionDatePicker;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RepairTypeComboBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.ComboBox FlatComboBox;
        private System.Windows.Forms.Label label6;
    }
}