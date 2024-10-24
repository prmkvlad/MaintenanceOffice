using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceOffice
{
    public partial class AddResidentForm : Form
    {
        public AddResidentForm()
        {
            InitializeComponent();
            LoadFlatData();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextBox.Text.Trim();
            string lastName = LastNameTextBox.Text.Trim();
            string phoneNumber = label5.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            int flatID = Convert.ToInt32(FlatComboBox.SelectedValue);

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) &&
                !string.IsNullOrEmpty(phoneNumber) && !string.IsNullOrEmpty(email) && flatID > 0)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
                {
                    try
                    {
                        connection.Open();

                        string query = "INSERT INTO Resident (FirstName, LastName, PhoneNumber, Email, FlatID) " +
                                       "VALUES (@firstName, @lastName, @phoneNumber, @email, @flatID)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@firstName", firstName);
                            command.Parameters.AddWithValue("@lastName", lastName);
                            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@flatID", flatID);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Мешканця додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
