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
    public partial class RepairRequestUserControl : UserControl
    {
        public RepairRequestUserControl()
        {
            InitializeComponent();
        }

        public DataGridView RepairRequestGridView
        {
            get { return this.RepairRequestTable; }
        }

        private void FilterRepairRequestBtn_Click(object sender, EventArgs e)
        {
            string selectedStatus = FilterRepairStatusComboBox.SelectedItem.ToString();

            string query = "SELECT * FROM RepairRequest WHERE Status = @status";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@status", selectedStatus);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    RepairRequestGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void ResetRepairRequestFilterBtn_Click(object sender, EventArgs e)
        {
            LoadAllRepairRequests();
        }

        private void UpdateRepairRequestBtn_Click(object sender, EventArgs e)
        {
            if (RepairRequestGridView.SelectedRows.Count > 0)
            {
                int selectedRequestID = Convert.ToInt32(RepairRequestGridView.SelectedRows[0].Cells["requestIDDataGridViewTextBoxColumn"].Value);

                string newStatus = UpdateRepairRequestStatusComboBox.SelectedItem.ToString();

                string query = "UPDATE RepairRequest SET Status = @newStatus WHERE RequestID = @requestID";

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@newStatus", newStatus);
                            command.Parameters.AddWithValue("@requestID", selectedRequestID);

                            command.ExecuteNonQuery();
                        }

                        string selectQuery = "SELECT * FROM RepairRequest";
                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        RepairRequestGridView.DataSource = dataTable;

                        MessageBox.Show("Статус заявки успішно оновлено!", "Оновлення успішне", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть заявку для оновлення.", "Помилка вибору", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddRepairRequestBtn_Click(object sender, EventArgs e)
        {
            AddRepairRequestForm addForm = new AddRepairRequestForm();

            addForm.ShowDialog();

            LoadAllRepairRequests();
        }

        private void LoadAllRepairRequests()
        {
            string query = "SELECT * FROM RepairRequest";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    RepairRequestGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

    }
}
