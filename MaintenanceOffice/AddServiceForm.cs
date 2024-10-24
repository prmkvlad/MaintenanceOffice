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
    public partial class AddServiceForm : Form
    {
        public AddServiceForm()
        {
            InitializeComponent();
            LoadHouseData();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string serviceName = ServiceNameTextBox.Text.Trim();
            float tariff = Convert.ToSingle(TariffTextBox.Text.Trim());
            int houseID = Convert.ToInt32(HouseComboBox.SelectedValue);

            string checkQuery = "SELECT COUNT(*) FROM UtilityService WHERE ServiceName = @serviceName AND HouseID = @houseID";

            string insertQuery = "INSERT INTO UtilityService (ServiceName, Tariff, HouseID) VALUES (@serviceName, @tariff, @houseID)";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@serviceName", serviceName);
                        checkCommand.Parameters.AddWithValue("@houseID", houseID);

                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Ця послуга вже додана для обраного будинку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@serviceName", serviceName);
                        insertCommand.Parameters.AddWithValue("@tariff", tariff);
                        insertCommand.Parameters.AddWithValue("@houseID", houseID);

                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Послуга успішно додана!", "Додавання успішне", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void LoadHouseData()
        {
            string query = "SELECT HouseID, Address FROM House";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    HouseComboBox.DataSource = dataTable;
                    HouseComboBox.DisplayMember = "Address";
                    HouseComboBox.ValueMember = "HouseID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження даних про будинки: " + ex.Message);
                }
            }
        }

    }
}
