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
    public partial class AccountingOfBuildingsUserControl : UserControl
    {
        public AccountingOfBuildingsUserControl()
        {
            InitializeComponent();
        }

        public DataGridView FlatGridView
        {
            get { return this.FlatTable; }
        }

        public DataGridView HouseGridView
        {
            get { return this.HouseTable; }
        }

        private void ShowFlatsBtn_Click(object sender, EventArgs e)
        {
            string selectedHouseText = SelectedHouseTextArea.Text.Trim();

            if (!int.TryParse(selectedHouseText, out int selectedHouseID))
            {
                MessageBox.Show("Будь ласка, введіть коректний ID будинку.", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT * FROM Flat WHERE HouseID = @houseID";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@houseID", selectedHouseID);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    FlatTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void SortFlatBtn_Click(object sender, EventArgs e)
        {
            string selectedColumn = SortFlatByComboBox.SelectedItem.ToString();

            string[] validColumns = { "FlatID", "FlatNumber", "FlatArea", "Status" };
            if (!validColumns.Contains(selectedColumn))
            {
                MessageBox.Show("Будь ласка, оберіть коректний стовпець для сортування.", "Помилка сортування", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"SELECT * FROM Flat ORDER BY {selectedColumn}";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jluct\\source\\repos\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    FlatTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void HouseSearchBtn_Click(object sender, EventArgs e)
        {
            string searchQuery = HouseSearchTextBox.Text.Trim();

            string query = "SELECT * FROM House WHERE Address LIKE @searchQuery OR ResponsiblePerson LIKE @searchQuery";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jluct\\source\\repos\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    HouseTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void UpdateHouseStatusBtn_Click(object sender, EventArgs e)
        {
            if (HouseTable.SelectedRows.Count > 0)
            {
                int selectedHouseID = Convert.ToInt32(HouseTable.SelectedRows[0].Cells["houseIDDataGridViewTextBoxColumn"].Value);

                string newTechnicalCondition = HouseTechStatusComboBox.SelectedItem.ToString();

                string query = "UPDATE House SET TechnicalCondition = @newCondition WHERE HouseID = @houseID";

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jluct\\source\\repos\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@newCondition", newTechnicalCondition);
                            command.Parameters.AddWithValue("@houseID", selectedHouseID);

                            command.ExecuteNonQuery();
                        }

                        string selectQuery = "SELECT * FROM House";

                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        HouseTable.DataSource = dataTable;

                        MessageBox.Show("Технічний стан будинку успішно оновлено!", "Оновлення успішне", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть будинок для оновлення.", "Помилка вибору", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
