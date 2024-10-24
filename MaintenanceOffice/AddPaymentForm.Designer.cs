namespace MaintenanceOffice
{
    partial class AddPaymentForm
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PaymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.ResidentComboBox = new System.Windows.Forms.ComboBox();
            this.PaymentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PaymentPurposeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.CancelBtn.TabIndex = 39;
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
            this.SaveBtn.TabIndex = 38;
            this.SaveBtn.Text = "Зберегти";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PaymentMethodComboBox
            // 
            this.PaymentMethodComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PaymentMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentMethodComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentMethodComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentMethodComboBox.FormattingEnabled = true;
            this.PaymentMethodComboBox.Items.AddRange(new object[] {
            "Cash",
            "Bank Transfer",
            "Credit Card"});
            this.PaymentMethodComboBox.Location = new System.Drawing.Point(170, 32);
            this.PaymentMethodComboBox.Name = "PaymentMethodComboBox";
            this.PaymentMethodComboBox.Size = new System.Drawing.Size(120, 25);
            this.PaymentMethodComboBox.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(170, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Мешканець";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Дата платежу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(167, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Метод оплати";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Сума";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.AmountTextBox.Location = new System.Drawing.Point(12, 34);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(120, 20);
            this.AmountTextBox.TabIndex = 28;
            // 
            // ResidentComboBox
            // 
            this.ResidentComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResidentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResidentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResidentComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResidentComboBox.FormattingEnabled = true;
            this.ResidentComboBox.Location = new System.Drawing.Point(170, 84);
            this.ResidentComboBox.Name = "ResidentComboBox";
            this.ResidentComboBox.Size = new System.Drawing.Size(120, 25);
            this.ResidentComboBox.TabIndex = 40;
            // 
            // PaymentDateDateTimePicker
            // 
            this.PaymentDateDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.PaymentDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PaymentDateDateTimePicker.Location = new System.Drawing.Point(12, 87);
            this.PaymentDateDateTimePicker.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.PaymentDateDateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.PaymentDateDateTimePicker.Name = "PaymentDateDateTimePicker";
            this.PaymentDateDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.PaymentDateDateTimePicker.TabIndex = 41;
            // 
            // PaymentPurposeComboBox
            // 
            this.PaymentPurposeComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PaymentPurposeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentPurposeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentPurposeComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentPurposeComboBox.FormattingEnabled = true;
            this.PaymentPurposeComboBox.Items.AddRange(new object[] {
            "Rent",
            "Utilities"});
            this.PaymentPurposeComboBox.Location = new System.Drawing.Point(91, 136);
            this.PaymentPurposeComboBox.Name = "PaymentPurposeComboBox";
            this.PaymentPurposeComboBox.Size = new System.Drawing.Size(120, 25);
            this.PaymentPurposeComboBox.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(88, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Призначення";
            // 
            // AddPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.PaymentPurposeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaymentDateDateTimePicker);
            this.Controls.Add(this.ResidentComboBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.PaymentMethodComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AmountTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox PaymentMethodComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.ComboBox ResidentComboBox;
        private System.Windows.Forms.DateTimePicker PaymentDateDateTimePicker;
        private System.Windows.Forms.ComboBox PaymentPurposeComboBox;
        private System.Windows.Forms.Label label1;
    }
}