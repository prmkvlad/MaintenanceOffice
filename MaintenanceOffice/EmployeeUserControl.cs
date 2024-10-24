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
    public partial class EmployeeUserControl : UserControl
    {
        public EmployeeUserControl()
        {
            InitializeComponent();
        }

        public DataGridView EmployeeGridView
        {
            get { return this.EmployeeTable; }
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();

            addEmployeeForm.ShowDialog();

            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            string query = "SELECT * FROM Employee";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    EmployeeTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження працівників: " + ex.Message);
                }
            }
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (EmployeeTable.SelectedRows.Count > 0)
            {
                int selectedEmployeeID = Convert.ToInt32(EmployeeTable.SelectedRows[0].Cells["EmployeeIDDataGridViewTextBoxColumn"].Value);

                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цього працівника?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Employee WHERE EmployeeID = @employeeID";

                    using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
                    {
                        try
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@employeeID", selectedEmployeeID);

                                command.ExecuteNonQuery();
                            }

                            LoadEmployeeData();

                            MessageBox.Show("Працівника успішно видалено!", "Видалення успішне", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Помилка: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть працівника для видалення.", "Помилка вибору", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (EmployeeTable.SelectedRows.Count > 0)
            {
                int selectedEmployeeID = Convert.ToInt32(EmployeeTable.SelectedRows[0].Cells["EmployeeIDDataGridViewTextBoxColumn"].Value);
                string firstName = EmployeeTable.SelectedRows[0].Cells["FirstNameDataGridViewTextBoxColumn"].Value.ToString();
                string lastName = EmployeeTable.SelectedRows[0].Cells["LastNameDataGridViewTextBoxColumn"].Value.ToString();
                string position = EmployeeTable.SelectedRows[0].Cells["PositionDataGridViewTextBoxColumn"].Value.ToString();
                string phoneNumber = EmployeeTable.SelectedRows[0].Cells["PhoneNumberDataGridViewTextBoxColumn"].Value.ToString();
                string email = EmployeeTable.SelectedRows[0].Cells["EmailDataGridViewTextBoxColumn"].Value.ToString();

                EditEmployeeForm editEmployeeForm = new EditEmployeeForm();

                editEmployeeForm.EmployeeID = selectedEmployeeID;
                editEmployeeForm.FirstName = firstName;
                editEmployeeForm.LastName = lastName;
                editEmployeeForm.Position = position;
                editEmployeeForm.PhoneNumber = phoneNumber;
                editEmployeeForm.Email = email;

                editEmployeeForm.ShowDialog();

                LoadEmployeeData();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть працівника для редагування.", "Помилка вибору", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
