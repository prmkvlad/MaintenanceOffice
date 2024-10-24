using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceOffice
{
    public partial class ReportsUserControl : UserControl
    {
        public ReportsUserControl()
        {
            InitializeComponent();
        }

        private void TechReportBtn_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT 
            h.HouseID, 
            h.Address, 
            h.TechnicalCondition, 
            rr.RepairType, 
            rr.Status AS RepairStatus, 
            rr.SubmissionDate AS RepairSubmissionDate, 
            rr.Description AS RepairDescription
        FROM House h
        LEFT JOIN RepairRequest rr ON h.HouseID = rr.FlatID
        ORDER BY h.HouseID";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    ReportTable.DataSource = dataTable;

                    MessageBox.Show("Звіт успішно згенеровано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при створенні звіту: " + ex.Message);
                }
            }
        }

        private void FinancialReportBtn_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT 
            r.ResidentID, 
            CONCAT(r.FirstName, ' ', r.LastName) AS ResidentName, 
            p.PaymentDate, 
            p.Amount, 
            p.PaymentPurpose, 
            (SELECT ISNULL(SUM(ps.Amount), 0) FROM Payment ps WHERE ps.ResidentID = r.ResidentID) AS TotalPaid,
            (SELECT ISNULL(SUM(u.Tariff), 0) FROM UtilityService u WHERE u.HouseID = f.HouseID) AS TotalCharged
        FROM Resident r
        LEFT JOIN Flat f ON r.FlatID = f.FlatID
        LEFT JOIN Payment p ON r.ResidentID = p.ResidentID
        ORDER BY r.ResidentID, p.PaymentDate";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    ReportTable.DataSource = dataTable;

                    MessageBox.Show("Фінансовий звіт успішно згенеровано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при створенні фінансового звіту: " + ex.Message);
                }
            }
        }

        private void RepairReportBtn_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT 
            rr.RequestID, 
            rr.RepairType, 
            rr.Status, 
            CONCAT(e.FirstName, ' ', e.LastName) AS AssignedEmployee 
        FROM RepairRequest rr
        LEFT JOIN Employee e ON rr.AssignedEmployee = e.EmployeeID
        WHERE rr.Status = 'Completed'
        ORDER BY rr.RequestID";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    ReportTable.DataSource = dataTable;

                    int completedRequestsCount = dataTable.Rows.Count;

                    MessageBox.Show($"Звіт про виконані заявки успішно згенеровано! Виконано заявок: {completedRequestsCount}.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при створенні звіту: " + ex.Message);
                }
            }
        }

    }
}
