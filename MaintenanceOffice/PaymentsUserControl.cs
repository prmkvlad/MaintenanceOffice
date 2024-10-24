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
    public partial class PaymentsUserControl : UserControl
    {
        public PaymentsUserControl()
        {
            InitializeComponent();
        }

        public DataGridView PaymentGridView
        {
            get { return this.PaymentTable; }
        }

        private void PaymentSearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = PaymentSearchTextBox.Text.Trim();

            string query = "SELECT * FROM Payment WHERE ResidentID IN " +
                           "(SELECT ResidentID FROM Resident WHERE FirstName LIKE @searchText OR LastName LIKE @searchText)";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    PaymentTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void PaymentFilterByTypeBtn_Click(object sender, EventArgs e)
        {
            string selectedPaymentMethod = FilterPaymentComboBox.SelectedItem.ToString();

            string query = "SELECT * FROM Payment WHERE PaymentMethod = @paymentMethod";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@paymentMethod", selectedPaymentMethod);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    PaymentTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void PaymentFilterByDateBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = FilterStartDate.Value;
            DateTime endDate = FilterEndDate.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Стартова дата не може бути більшою за кінцеву дату.", "Помилка дат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT * FROM Payment WHERE PaymentDate BETWEEN @startDate AND @endDate";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@startDate", startDate);
                    adapter.SelectCommand.Parameters.AddWithValue("@endDate", endDate);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    PaymentTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void ResetPaymentFilterBtn_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void AddPaymentBtn_Click(object sender, EventArgs e)
        {
            AddPaymentForm addForm = new AddPaymentForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                FillTable();
            }
        }

        private void FillTable()
        {
            string query = "SELECT * FROM Payment";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    PaymentTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }
    }
}
