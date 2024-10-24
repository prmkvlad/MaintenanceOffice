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
    public partial class MainForm : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True");
        public MainForm()
        {
            InitializeComponent();
            SidePanel.Height = RepairRequestBtn.Height;
            SidePanel.Top = RepairRequestBtn.Top;
            repairRequestUserControl1.BringToFront();
        }

        private void AccountingOfBuildingsBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = AccountingOfBuildingsBtn.Height;
            SidePanel.Top = AccountingOfBuildingsBtn.Top;
            accountingOfBuildingsUserControl1.BringToFront();
        }

        private void ResidentsBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ResidentsBtn.Height;
            SidePanel.Top = ResidentsBtn.Top;
            residentsUserControl1.BringToFront();
        }

        private void PaymentsBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = PaymentsBtn.Height;
            SidePanel.Top = PaymentsBtn.Top;
            paymentsUserControl1.BringToFront();
        }

        private void UtilitiesBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = UtilitiesBtn.Height;
            SidePanel.Top = UtilitiesBtn.Top;
            utilitiesUserControl1.BringToFront();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ReportsBtn.Height;
            SidePanel.Top = ReportsBtn.Top;
            reportsUserControl1.BringToFront();
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = EmployeeBtn.Height;
            SidePanel.Top = EmployeeBtn.Top;
            employeeUserControl1.BringToFront();
        }

        private void RepairRequestBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = RepairRequestBtn.Height;
            SidePanel.Top = RepairRequestBtn.Top;
            repairRequestUserControl1.BringToFront();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData("RepairRequest", repairRequestUserControl1.RepairRequestGridView);
            LoadData("Payment", paymentsUserControl1.PaymentGridView);
            LoadData("Resident", residentsUserControl1.ResidentGridView);
            LoadData("House", accountingOfBuildingsUserControl1.HouseGridView);
            LoadData("Flat", accountingOfBuildingsUserControl1.FlatGridView);
            LoadData("Employee", employeeUserControl1.EmployeeGridView);
            LoadData("UtilityService", utilitiesUserControl1.UtilitiesGridView);
        }

        private void LoadData(string tableName, DataGridView dataGridView)
        {
            string query = $"SELECT * FROM {tableName}";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dataGridView.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження даних з таблиці " + tableName + ": " + ex.Message);
                }
            }
        }
    }
}
