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
    public partial class EditEmployeeForm : Form
    {
        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        public int EmployeeID { get; set; }

        public string FirstName
        {
            get { return FirstNameTextBox.Text; }
            set { FirstNameTextBox.Text = value; }
        }

        public string LastName
        {
            get { return LastNameTextBox.Text; }
            set { LastNameTextBox.Text = value; }
        }

        public string Position
        {
            get { return PositionTextBox.Text; }
            set { PositionTextBox.Text = value; }
        }

        public string PhoneNumber
        {
            get { return PhoneNumberTextBox.Text; }
            set { PhoneNumberTextBox.Text = value; }
        }

        public string Email
        {
            get { return EmailTextBox.Text; }
            set { EmailTextBox.Text = value; }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextBox.Text.Trim();
            string lastName = LastNameTextBox.Text.Trim();
            string position = PositionTextBox.Text.Trim();
            string phoneNumber = PhoneNumberTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(position) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Employee SET FirstName = @firstName, LastName = @lastName, Position = @position, " +
                           "PhoneNumber = @phoneNumber, Email = @email WHERE EmployeeID = @employeeID";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@position", position);
                        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@employeeID", EmployeeID);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Дані працівника успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }
    }
}
