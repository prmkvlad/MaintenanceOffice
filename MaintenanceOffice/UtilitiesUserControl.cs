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
    public partial class UtilitiesUserControl : UserControl
    {
        public UtilitiesUserControl()
        {
            InitializeComponent();
        }

        public DataGridView UtilitiesGridView
        {
            get { return this.UtilitiesTable; }
        }

        private void AddServiceBtn_Click(object sender, EventArgs e)
        {
            AddServiceForm addServiceForm = new AddServiceForm();

            addServiceForm.ShowDialog();

            LoadAllUtilities();
        }

        private void LoadAllUtilities()
        {
            string query = "SELECT * FROM UtilityService";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    UtilitiesTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void EditServiceBtn_Click(object sender, EventArgs e)
        {
            if (UtilitiesTable.SelectedRows.Count > 0)
            {
                int selectedServiceID = Convert.ToInt32(UtilitiesTable.SelectedRows[0].Cells["ServiceIDDataGridViewTextBoxColumn"].Value);

                float newTariff;
                if (float.TryParse(NewTarifTextBox.Text.Trim(), out newTariff))
                {
                    string query = "UPDATE UtilityService SET Tariff = @newTariff WHERE ServiceID = @serviceID";

                    using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
                    {
                        try
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@newTariff", newTariff);
                                command.Parameters.AddWithValue("@serviceID", selectedServiceID);

                                command.ExecuteNonQuery();
                            }

                            string selectQuery = "SELECT * FROM UtilityService";
                            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            UtilitiesTable.DataSource = dataTable;

                            MessageBox.Show("Тариф успішно оновлено!", "Оновлення успішне", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Помилка: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Будь ласка, введіть коректне значення тарифу.", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть рядок для зміни тарифу.", "Помилка вибору", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteServiceBtn_Click(object sender, EventArgs e)
        {
            if (UtilitiesTable.SelectedRows.Count > 0)
            {
                int selectedServiceID = Convert.ToInt32(UtilitiesTable.SelectedRows[0].Cells["ServiceIDDataGridViewTextBoxColumn"].Value);

                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цю послугу?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM UtilityService WHERE ServiceID = @serviceID";

                    using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
                    {
                        try
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@serviceID", selectedServiceID);

                                command.ExecuteNonQuery();
                            }

                            string selectQuery = "SELECT * FROM UtilityService";
                            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            UtilitiesTable.DataSource = dataTable;

                            MessageBox.Show("Послугу успішно видалено!", "Видалення успішне", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Будь ласка, виберіть послугу для видалення.", "Помилка вибору", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
