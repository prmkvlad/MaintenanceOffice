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
    public partial class AddRepairRequestForm : Form
    {
        public AddRepairRequestForm()
        {
            InitializeComponent();
            LoadEmployeeData();
            LoadFlatData();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string repairType = RepairTypeComboBox.SelectedItem.ToString();
            DateTime submissionDate = SubmissionDatePicker.Value;
            string status = StatusComboBox.SelectedItem.ToString();
            string description = DescriptionTextBox.Text;
            int assignedEmployeeID = Convert.ToInt32(AssignedEmployeeComboBox.SelectedValue);
            int flatID = Convert.ToInt32(FlatComboBox.SelectedValue);

            string query = "INSERT INTO RepairRequest (RepairType, SubmissionDate, Status, Description, AssignedEmployee, FlatID) " +
                           "VALUES (@repairType, @submissionDate, @status, @description, @assignedEmployee, @flatID)";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@repairType", repairType);
                        command.Parameters.AddWithValue("@submissionDate", submissionDate);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@assignedEmployee", assignedEmployeeID);
                        command.Parameters.AddWithValue("@flatID", flatID);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Заявка на ремонт успішно додана!", "Додавання успішне", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void LoadFlatData()
        {
            string query = "SELECT FlatID, FlatNumber FROM Flat";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable flatTable = new DataTable();

                    adapter.Fill(flatTable);

                    FlatComboBox.DataSource = flatTable;

                    FlatComboBox.DisplayMember = "FlatNumber";

                    FlatComboBox.ValueMember = "FlatID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void LoadEmployeeData()
        {
            string query = "SELECT EmployeeID, CONCAT(FirstName, ' ', LastName) AS FullName FROM Employee";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    AssignedEmployeeComboBox.DataSource = dataTable;
                    AssignedEmployeeComboBox.DisplayMember = "FullName";  // Відображаємо ім'я та прізвище
                    AssignedEmployeeComboBox.ValueMember = "EmployeeID";  // Зберігаємо EmployeeID як значення
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження даних працівників: " + ex.Message);
                }
            }
        }

    }
}
