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
    public partial class EditResidentForm : Form
    {
        public EditResidentForm()
        {
            InitializeComponent();
        }
        public int ResidentID { get; set; }

        public string ResidentFirstName
        {
            get { return ResidentFirstNameTextBox.Text; }
            set { ResidentFirstNameTextBox.Text = value; }
        }

        public string ResidentLastName
        {
            get { return ResidentLastNameTextBox.Text; }
            set { ResidentLastNameTextBox.Text = value; }
        }

        public string ResidentPhoneNumber
        {
            get { return ResidentPhoneNumberTextBox.Text; }
            set { ResidentPhoneNumberTextBox.Text = value; }
        }

        public string ResidentEmail
        {
            get { return ResidentEmailTextBox.Text; }
            set { ResidentEmailTextBox.Text = value; }
        }

        private void ResidentCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResidentSaveChangesBtn_Click(object sender, EventArgs e)
        {
            string updatedFirstName = ResidentFirstNameTextBox.Text.Trim();
            string updatedLastName = ResidentLastNameTextBox.Text.Trim();
            string updatedPhoneNumber = ResidentPhoneNumberTextBox.Text.Trim();
            string updatedEmail = ResidentEmailTextBox.Text.Trim();

            int residentID = this.ResidentID;

            if (!string.IsNullOrEmpty(updatedFirstName) && !string.IsNullOrEmpty(updatedLastName) &&
                !string.IsNullOrEmpty(updatedPhoneNumber) && !string.IsNullOrEmpty(updatedEmail))
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE Resident SET FirstName = @firstName, LastName = @lastName, PhoneNumber = @phoneNumber, Email = @email WHERE ResidentID = @residentID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@firstName", updatedFirstName);
                            command.Parameters.AddWithValue("@lastName", updatedLastName);
                            command.Parameters.AddWithValue("@phoneNumber", updatedPhoneNumber);
                            command.Parameters.AddWithValue("@email", updatedEmail);
                            command.Parameters.AddWithValue("@residentID", residentID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Зміни збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Помилка при збереженні змін.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка: " + ex.Message);
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
