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
    public partial class ResidentsUserControl : UserControl
    {
        public ResidentsUserControl()
        {
            InitializeComponent();
        }

        public DataGridView ResidentGridView
        {
            get { return this.ResidentTable; }
        }

        private void ResidentSearchBtn_Click(object sender, EventArgs e)
        {
            string searchQuery = ResidentSearchTextBox.Text.Trim();

            string query = "SELECT Resident.*, Flat.FlatNumber FROM Resident " +
                           "JOIN Flat ON Resident.FlatID = Flat.FlatID " +
                           "WHERE FirstName LIKE @searchQuery OR LastName LIKE @searchQuery " +
                           "OR PhoneNumber LIKE @searchQuery OR Email LIKE @searchQuery";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    ResidentTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void ResetResidentFilterBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT Resident.*, Flat.FlatNumber FROM Resident " +
                           "JOIN Flat ON Resident.FlatID = Flat.FlatID";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    ResidentTable.DataSource = dataTable;

                    ResidentSearchTextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void ResidentFilterBtn_Click(object sender, EventArgs e)
        {
            string selectedFilter = FilterResidentComboBox.SelectedItem.ToString();

            string query = "SELECT Resident.*, Flat.FlatNumber, Flat.Status FROM Resident " +
                           "JOIN Flat ON Resident.FlatID = Flat.FlatID " +
                           "WHERE Flat.Status = @selectedFilter";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@selectedFilter", selectedFilter);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    ResidentTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void EditResidentBtn_Click(object sender, EventArgs e)
        {
            if (ResidentTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ResidentTable.SelectedRows[0];
                string firstName = selectedRow.Cells["FirstNameDataGridViewTextBoxColumn"].Value.ToString();
                string lastName = selectedRow.Cells["LastNameDataGridViewTextBoxColumn"].Value.ToString();
                string phoneNumber = selectedRow.Cells["PhoneNumberDataGridViewTextBoxColumn"].Value.ToString();
                string email = selectedRow.Cells["EmailDataGridViewTextBoxColumn"].Value.ToString();
                int residentID = Convert.ToInt32(selectedRow.Cells["ResidentIDDataGridViewTextBoxColumn"].Value);

                EditResidentForm editForm = new EditResidentForm();

                editForm.ResidentFirstName = firstName;
                editForm.ResidentLastName = lastName;
                editForm.ResidentPhoneNumber = phoneNumber;
                editForm.ResidentEmail = email;
                editForm.ResidentID = residentID;

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadResidentData();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть мешканця для редагування.", "Помилка вибору", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadResidentData()
        {
            string query = "SELECT Resident.*, Flat.FlatNumber FROM Resident " +
                           "JOIN Flat ON Resident.FlatID = Flat.FlatID";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    ResidentTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void AddResidentBtn_Click(object sender, EventArgs e)
        {
            AddResidentForm addForm = new AddResidentForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadResidentData();
            }
        }
    }
}
