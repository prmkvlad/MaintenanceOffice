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
    public partial class AddPaymentForm : Form
    {
        public AddPaymentForm()
        {
            InitializeComponent();
            LoadResidentData();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            float amount = Convert.ToSingle(AmountTextBox.Text.Trim());
            DateTime paymentDate = PaymentDateDateTimePicker.Value;
            string paymentMethod = PaymentMethodComboBox.SelectedItem.ToString();
            int residentID = Convert.ToInt32(ResidentComboBox.SelectedValue);
            string paymentPurpose = PaymentPurposeComboBox.SelectedItem.ToString();
            int flatID = GetSelectedFlatID();

            if (amount > 0 && residentID > 0 && !string.IsNullOrEmpty(paymentMethod) && !string.IsNullOrEmpty(paymentPurpose) && flatID > 0)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
                {
                    try
                    {
                        connection.Open();

                        string query = "INSERT INTO Payment (PaymentDate, Amount, PaymentMethod, PaymentPurpose, ResidentID, FlatID) " +
                                       "VALUES (@paymentDate, @amount, @paymentMethod, @paymentPurpose, @residentID, @flatID)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@paymentDate", paymentDate);
                            command.Parameters.AddWithValue("@amount", amount);
                            command.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                            command.Parameters.AddWithValue("@paymentPurpose", paymentPurpose);
                            command.Parameters.AddWithValue("@residentID", residentID);
                            command.Parameters.AddWithValue("@flatID", flatID);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Платіж додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadResidentData()
        {
            string query = "SELECT ResidentID, FirstName + ' ' + LastName AS FullName, FlatID FROM Resident";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\folders\\Дистанційка\\НАУ\\3 курс\\БД\\KP\\MaintenanceOffice\\MaintenanceOffice\\MaintenanceOffice.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable residentTable = new DataTable();

                    adapter.Fill(residentTable);

                    ResidentComboBox.DataSource = residentTable;

                    ResidentComboBox.DisplayMember = "FullName";

                    ResidentComboBox.ValueMember = "ResidentID";

                    ResidentComboBox.Tag = residentTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private int GetSelectedFlatID()
        {
            int selectedResidentID = Convert.ToInt32(ResidentComboBox.SelectedValue);

            DataTable residentTable = ResidentComboBox.Tag as DataTable;

            if (residentTable != null)
            {
                DataRow[] rows = residentTable.Select("ResidentID = " + selectedResidentID);
                if (rows.Length > 0)
                {
                    return Convert.ToInt32(rows[0]["FlatID"]);
                }
            }

            return 0;
        }

    }
}
