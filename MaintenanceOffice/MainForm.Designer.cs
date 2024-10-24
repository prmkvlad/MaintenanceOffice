namespace MaintenanceOffice
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.EmployeeBtn = new System.Windows.Forms.Button();
            this.ReportsBtn = new System.Windows.Forms.Button();
            this.UtilitiesBtn = new System.Windows.Forms.Button();
            this.PaymentsBtn = new System.Windows.Forms.Button();
            this.ResidentsBtn = new System.Windows.Forms.Button();
            this.AccountingOfBuildingsBtn = new System.Windows.Forms.Button();
            this.RepairRequestBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.repairRequestUserControl1 = new MaintenanceOffice.RepairRequestUserControl();
            this.accountingOfBuildingsUserControl1 = new MaintenanceOffice.AccountingOfBuildingsUserControl();
            this.residentsUserControl1 = new MaintenanceOffice.ResidentsUserControl();
            this.paymentsUserControl1 = new MaintenanceOffice.PaymentsUserControl();
            this.utilitiesUserControl1 = new MaintenanceOffice.UtilitiesUserControl();
            this.reportsUserControl1 = new MaintenanceOffice.ReportsUserControl();
            this.employeeUserControl1 = new MaintenanceOffice.EmployeeUserControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.EmployeeBtn);
            this.panel1.Controls.Add(this.ReportsBtn);
            this.panel1.Controls.Add(this.UtilitiesBtn);
            this.panel1.Controls.Add(this.PaymentsBtn);
            this.panel1.Controls.Add(this.ResidentsBtn);
            this.panel1.Controls.Add(this.AccountingOfBuildingsBtn);
            this.panel1.Controls.Add(this.RepairRequestBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 550);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 50);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 63);
            this.SidePanel.TabIndex = 3;
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.FlatAppearance.BorderSize = 0;
            this.EmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.EmployeeBtn.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeBtn.Image")));
            this.EmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeBtn.Location = new System.Drawing.Point(12, 463);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Size = new System.Drawing.Size(227, 63);
            this.EmployeeBtn.TabIndex = 9;
            this.EmployeeBtn.Text = "   Працівники";
            this.EmployeeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmployeeBtn.UseVisualStyleBackColor = true;
            this.EmployeeBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.FlatAppearance.BorderSize = 0;
            this.ReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportsBtn.ForeColor = System.Drawing.Color.White;
            this.ReportsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReportsBtn.Image")));
            this.ReportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportsBtn.Location = new System.Drawing.Point(12, 394);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(227, 63);
            this.ReportsBtn.TabIndex = 8;
            this.ReportsBtn.Text = "   Звіти";
            this.ReportsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReportsBtn.UseVisualStyleBackColor = true;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // UtilitiesBtn
            // 
            this.UtilitiesBtn.FlatAppearance.BorderSize = 0;
            this.UtilitiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UtilitiesBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UtilitiesBtn.ForeColor = System.Drawing.Color.White;
            this.UtilitiesBtn.Image = ((System.Drawing.Image)(resources.GetObject("UtilitiesBtn.Image")));
            this.UtilitiesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UtilitiesBtn.Location = new System.Drawing.Point(12, 325);
            this.UtilitiesBtn.Name = "UtilitiesBtn";
            this.UtilitiesBtn.Size = new System.Drawing.Size(227, 63);
            this.UtilitiesBtn.TabIndex = 7;
            this.UtilitiesBtn.Text = "   Комунальні послуги";
            this.UtilitiesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UtilitiesBtn.UseVisualStyleBackColor = true;
            this.UtilitiesBtn.Click += new System.EventHandler(this.UtilitiesBtn_Click);
            // 
            // PaymentsBtn
            // 
            this.PaymentsBtn.FlatAppearance.BorderSize = 0;
            this.PaymentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentsBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentsBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentsBtn.Image = ((System.Drawing.Image)(resources.GetObject("PaymentsBtn.Image")));
            this.PaymentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaymentsBtn.Location = new System.Drawing.Point(12, 256);
            this.PaymentsBtn.Name = "PaymentsBtn";
            this.PaymentsBtn.Size = new System.Drawing.Size(227, 63);
            this.PaymentsBtn.TabIndex = 6;
            this.PaymentsBtn.Text = "   Платежі";
            this.PaymentsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PaymentsBtn.UseVisualStyleBackColor = true;
            this.PaymentsBtn.Click += new System.EventHandler(this.PaymentsBtn_Click);
            // 
            // ResidentsBtn
            // 
            this.ResidentsBtn.FlatAppearance.BorderSize = 0;
            this.ResidentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResidentsBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResidentsBtn.ForeColor = System.Drawing.Color.White;
            this.ResidentsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ResidentsBtn.Image")));
            this.ResidentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResidentsBtn.Location = new System.Drawing.Point(12, 187);
            this.ResidentsBtn.Name = "ResidentsBtn";
            this.ResidentsBtn.Size = new System.Drawing.Size(227, 63);
            this.ResidentsBtn.TabIndex = 5;
            this.ResidentsBtn.Text = "   Мешканці";
            this.ResidentsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ResidentsBtn.UseVisualStyleBackColor = true;
            this.ResidentsBtn.Click += new System.EventHandler(this.ResidentsBtn_Click);
            // 
            // AccountingOfBuildingsBtn
            // 
            this.AccountingOfBuildingsBtn.FlatAppearance.BorderSize = 0;
            this.AccountingOfBuildingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountingOfBuildingsBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountingOfBuildingsBtn.ForeColor = System.Drawing.Color.White;
            this.AccountingOfBuildingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("AccountingOfBuildingsBtn.Image")));
            this.AccountingOfBuildingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountingOfBuildingsBtn.Location = new System.Drawing.Point(12, 119);
            this.AccountingOfBuildingsBtn.Name = "AccountingOfBuildingsBtn";
            this.AccountingOfBuildingsBtn.Size = new System.Drawing.Size(227, 63);
            this.AccountingOfBuildingsBtn.TabIndex = 4;
            this.AccountingOfBuildingsBtn.Text = "   Облік будинків";
            this.AccountingOfBuildingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AccountingOfBuildingsBtn.UseVisualStyleBackColor = true;
            this.AccountingOfBuildingsBtn.Click += new System.EventHandler(this.AccountingOfBuildingsBtn_Click);
            // 
            // RepairRequestBtn
            // 
            this.RepairRequestBtn.FlatAppearance.BorderSize = 0;
            this.RepairRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepairRequestBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepairRequestBtn.ForeColor = System.Drawing.Color.White;
            this.RepairRequestBtn.Image = ((System.Drawing.Image)(resources.GetObject("RepairRequestBtn.Image")));
            this.RepairRequestBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RepairRequestBtn.Location = new System.Drawing.Point(12, 50);
            this.RepairRequestBtn.Name = "RepairRequestBtn";
            this.RepairRequestBtn.Size = new System.Drawing.Size(227, 63);
            this.RepairRequestBtn.TabIndex = 3;
            this.RepairRequestBtn.Text = "   Заявки на ремонт";
            this.RepairRequestBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RepairRequestBtn.UseVisualStyleBackColor = true;
            this.RepairRequestBtn.Click += new System.EventHandler(this.RepairRequestBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(239, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(251, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 112);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(955, 25);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(29, 29);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // repairRequestUserControl1
            // 
            this.repairRequestUserControl1.BackColor = System.Drawing.Color.White;
            this.repairRequestUserControl1.Location = new System.Drawing.Point(239, 119);
            this.repairRequestUserControl1.Name = "repairRequestUserControl1";
            this.repairRequestUserControl1.Size = new System.Drawing.Size(761, 431);
            this.repairRequestUserControl1.TabIndex = 11;
            // 
            // accountingOfBuildingsUserControl1
            // 
            this.accountingOfBuildingsUserControl1.BackColor = System.Drawing.Color.White;
            this.accountingOfBuildingsUserControl1.Location = new System.Drawing.Point(239, 119);
            this.accountingOfBuildingsUserControl1.Name = "accountingOfBuildingsUserControl1";
            this.accountingOfBuildingsUserControl1.Size = new System.Drawing.Size(761, 431);
            this.accountingOfBuildingsUserControl1.TabIndex = 12;
            // 
            // residentsUserControl1
            // 
            this.residentsUserControl1.BackColor = System.Drawing.Color.White;
            this.residentsUserControl1.Location = new System.Drawing.Point(239, 119);
            this.residentsUserControl1.Name = "residentsUserControl1";
            this.residentsUserControl1.Size = new System.Drawing.Size(761, 431);
            this.residentsUserControl1.TabIndex = 13;
            // 
            // paymentsUserControl1
            // 
            this.paymentsUserControl1.BackColor = System.Drawing.Color.White;
            this.paymentsUserControl1.Location = new System.Drawing.Point(239, 119);
            this.paymentsUserControl1.Name = "paymentsUserControl1";
            this.paymentsUserControl1.Size = new System.Drawing.Size(761, 431);
            this.paymentsUserControl1.TabIndex = 14;
            // 
            // utilitiesUserControl1
            // 
            this.utilitiesUserControl1.BackColor = System.Drawing.Color.White;
            this.utilitiesUserControl1.Location = new System.Drawing.Point(239, 119);
            this.utilitiesUserControl1.Name = "utilitiesUserControl1";
            this.utilitiesUserControl1.Size = new System.Drawing.Size(761, 431);
            this.utilitiesUserControl1.TabIndex = 15;
            // 
            // reportsUserControl1
            // 
            this.reportsUserControl1.BackColor = System.Drawing.Color.White;
            this.reportsUserControl1.Location = new System.Drawing.Point(239, 119);
            this.reportsUserControl1.Name = "reportsUserControl1";
            this.reportsUserControl1.Size = new System.Drawing.Size(761, 431);
            this.reportsUserControl1.TabIndex = 16;
            // 
            // employeeUserControl1
            // 
            this.employeeUserControl1.Location = new System.Drawing.Point(239, 119);
            this.employeeUserControl1.Name = "employeeUserControl1";
            this.employeeUserControl1.Size = new System.Drawing.Size(761, 431);
            this.employeeUserControl1.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.employeeUserControl1);
            this.Controls.Add(this.reportsUserControl1);
            this.Controls.Add(this.utilitiesUserControl1);
            this.Controls.Add(this.paymentsUserControl1);
            this.Controls.Add(this.residentsUserControl1);
            this.Controls.Add(this.accountingOfBuildingsUserControl1);
            this.Controls.Add(this.repairRequestUserControl1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЖЕК";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RepairRequestBtn;
        private System.Windows.Forms.Button EmployeeBtn;
        private System.Windows.Forms.Button ReportsBtn;
        private System.Windows.Forms.Button UtilitiesBtn;
        private System.Windows.Forms.Button PaymentsBtn;
        private System.Windows.Forms.Button ResidentsBtn;
        private System.Windows.Forms.Button AccountingOfBuildingsBtn;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button ExitBtn;
        private RepairRequestUserControl repairRequestUserControl1;
        private AccountingOfBuildingsUserControl accountingOfBuildingsUserControl1;
        private ResidentsUserControl residentsUserControl1;
        private PaymentsUserControl paymentsUserControl1;
        private UtilitiesUserControl utilitiesUserControl1;
        private ReportsUserControl reportsUserControl1;
        private EmployeeUserControl employeeUserControl1;
    }
}

