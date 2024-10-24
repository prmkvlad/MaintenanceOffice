namespace MaintenanceOffice
{
    partial class ReportsUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReportTable = new System.Windows.Forms.DataGridView();
            this.TechReportBtn = new System.Windows.Forms.Button();
            this.RepairReportBtn = new System.Windows.Forms.Button();
            this.FinancialReportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Report Table";
            // 
            // ReportTable
            // 
            this.ReportTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportTable.Location = new System.Drawing.Point(3, 164);
            this.ReportTable.Name = "ReportTable";
            this.ReportTable.Size = new System.Drawing.Size(755, 264);
            this.ReportTable.TabIndex = 7;
            // 
            // TechReportBtn
            // 
            this.TechReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.TechReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TechReportBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechReportBtn.ForeColor = System.Drawing.Color.White;
            this.TechReportBtn.Location = new System.Drawing.Point(18, 67);
            this.TechReportBtn.Name = "TechReportBtn";
            this.TechReportBtn.Size = new System.Drawing.Size(287, 35);
            this.TechReportBtn.TabIndex = 16;
            this.TechReportBtn.Text = "Звіт про технічний стан будинків";
            this.TechReportBtn.UseVisualStyleBackColor = false;
            this.TechReportBtn.Click += new System.EventHandler(this.TechReportBtn_Click);
            // 
            // RepairReportBtn
            // 
            this.RepairReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.RepairReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepairReportBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepairReportBtn.ForeColor = System.Drawing.Color.White;
            this.RepairReportBtn.Location = new System.Drawing.Point(454, 67);
            this.RepairReportBtn.Name = "RepairReportBtn";
            this.RepairReportBtn.Size = new System.Drawing.Size(287, 35);
            this.RepairReportBtn.TabIndex = 17;
            this.RepairReportBtn.Text = "Звіт про виконані заявки на ремонт";
            this.RepairReportBtn.UseVisualStyleBackColor = false;
            this.RepairReportBtn.Click += new System.EventHandler(this.RepairReportBtn_Click);
            // 
            // FinancialReportBtn
            // 
            this.FinancialReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.FinancialReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinancialReportBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinancialReportBtn.ForeColor = System.Drawing.Color.White;
            this.FinancialReportBtn.Location = new System.Drawing.Point(311, 67);
            this.FinancialReportBtn.Name = "FinancialReportBtn";
            this.FinancialReportBtn.Size = new System.Drawing.Size(137, 35);
            this.FinancialReportBtn.TabIndex = 18;
            this.FinancialReportBtn.Text = "Фінансовий звіт";
            this.FinancialReportBtn.UseVisualStyleBackColor = false;
            this.FinancialReportBtn.Click += new System.EventHandler(this.FinancialReportBtn_Click);
            // 
            // ReportsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FinancialReportBtn);
            this.Controls.Add(this.RepairReportBtn);
            this.Controls.Add(this.TechReportBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportTable);
            this.Name = "ReportsUserControl";
            this.Size = new System.Drawing.Size(761, 431);
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ReportTable;
        private System.Windows.Forms.Button TechReportBtn;
        private System.Windows.Forms.Button RepairReportBtn;
        private System.Windows.Forms.Button FinancialReportBtn;
    }
}
