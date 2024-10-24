namespace MaintenanceOffice
{
    partial class EditResidentForm
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
            this.ResidentFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.ResidentPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.ResidentLastNameTextBox = new System.Windows.Forms.TextBox();
            this.ResidentEmailTextBox = new System.Windows.Forms.TextBox();
            this.ResidentSaveChangesBtn = new System.Windows.Forms.Button();
            this.ResidentCancelBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResidentFirstNameTextBox
            // 
            this.ResidentFirstNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ResidentFirstNameTextBox.Location = new System.Drawing.Point(12, 36);
            this.ResidentFirstNameTextBox.Name = "ResidentFirstNameTextBox";
            this.ResidentFirstNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.ResidentFirstNameTextBox.TabIndex = 8;
            // 
            // ResidentPhoneNumberTextBox
            // 
            this.ResidentPhoneNumberTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ResidentPhoneNumberTextBox.Location = new System.Drawing.Point(168, 36);
            this.ResidentPhoneNumberTextBox.Name = "ResidentPhoneNumberTextBox";
            this.ResidentPhoneNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.ResidentPhoneNumberTextBox.TabIndex = 9;
            // 
            // ResidentLastNameTextBox
            // 
            this.ResidentLastNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ResidentLastNameTextBox.Location = new System.Drawing.Point(12, 92);
            this.ResidentLastNameTextBox.Name = "ResidentLastNameTextBox";
            this.ResidentLastNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.ResidentLastNameTextBox.TabIndex = 10;
            // 
            // ResidentEmailTextBox
            // 
            this.ResidentEmailTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ResidentEmailTextBox.Location = new System.Drawing.Point(168, 92);
            this.ResidentEmailTextBox.Name = "ResidentEmailTextBox";
            this.ResidentEmailTextBox.Size = new System.Drawing.Size(120, 20);
            this.ResidentEmailTextBox.TabIndex = 11;
            // 
            // ResidentSaveChangesBtn
            // 
            this.ResidentSaveChangesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ResidentSaveChangesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResidentSaveChangesBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResidentSaveChangesBtn.ForeColor = System.Drawing.Color.White;
            this.ResidentSaveChangesBtn.Location = new System.Drawing.Point(82, 144);
            this.ResidentSaveChangesBtn.Name = "ResidentSaveChangesBtn";
            this.ResidentSaveChangesBtn.Size = new System.Drawing.Size(138, 35);
            this.ResidentSaveChangesBtn.TabIndex = 12;
            this.ResidentSaveChangesBtn.Text = "Зберегти";
            this.ResidentSaveChangesBtn.UseVisualStyleBackColor = false;
            this.ResidentSaveChangesBtn.Click += new System.EventHandler(this.ResidentSaveChangesBtn_Click);
            // 
            // ResidentCancelBtn
            // 
            this.ResidentCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ResidentCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResidentCancelBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResidentCancelBtn.ForeColor = System.Drawing.Color.White;
            this.ResidentCancelBtn.Location = new System.Drawing.Point(82, 195);
            this.ResidentCancelBtn.Name = "ResidentCancelBtn";
            this.ResidentCancelBtn.Size = new System.Drawing.Size(138, 35);
            this.ResidentCancelBtn.TabIndex = 13;
            this.ResidentCancelBtn.Text = "Скасувати";
            this.ResidentCancelBtn.UseVisualStyleBackColor = false;
            this.ResidentCancelBtn.Click += new System.EventHandler(this.ResidentCancelBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ім\'я";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(165, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Номер телефону";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(165, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Пошта";
            // 
            // EditResidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResidentCancelBtn);
            this.Controls.Add(this.ResidentSaveChangesBtn);
            this.Controls.Add(this.ResidentEmailTextBox);
            this.Controls.Add(this.ResidentLastNameTextBox);
            this.Controls.Add(this.ResidentPhoneNumberTextBox);
            this.Controls.Add(this.ResidentFirstNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditResidentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditResidentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResidentFirstNameTextBox;
        private System.Windows.Forms.TextBox ResidentPhoneNumberTextBox;
        private System.Windows.Forms.TextBox ResidentLastNameTextBox;
        private System.Windows.Forms.TextBox ResidentEmailTextBox;
        private System.Windows.Forms.Button ResidentSaveChangesBtn;
        private System.Windows.Forms.Button ResidentCancelBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}