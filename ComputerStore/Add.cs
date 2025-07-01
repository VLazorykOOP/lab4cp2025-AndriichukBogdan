using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComputerStore
{
    public partial class Add : Form
    {
        private string connectionString = "server=localhost;user=root;password=10011111Ok;database=laba3;";

        public Add()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string cpuType = textBoxCPUType.Text.Trim();
            string cpuSpeed = textBoxCPUSpeed.Text.Trim();
            string gpu = textBoxGPU.Text.Trim();
            string cdType = textBoxCD.Text.Trim();
            string sound = textBoxSound.Text.Trim();
            string hdd = textBoxHDD.Text.Trim();

            if (name == "" || cpuType == "" || cpuSpeed == "" || gpu == "" || cdType == "" || sound == "" || hdd == "")
            {
                MessageBox.Show("Заповніть усі поля!");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO computers (name, cpu_type, cpu_speed, gpu, cd_type, sound_card, hdd_size) " +
                                   "VALUES (@name, @cpu_type, @cpu_speed, @gpu, @cd_type, @sound_card, @hdd_size)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@cpu_type", cpuType);
                        cmd.Parameters.AddWithValue("@cpu_speed", Convert.ToDecimal(cpuSpeed));
                        cmd.Parameters.AddWithValue("@gpu", gpu);
                        cmd.Parameters.AddWithValue("@cd_type", cdType);
                        cmd.Parameters.AddWithValue("@sound_card", sound);
                        cmd.Parameters.AddWithValue("@hdd_size", Convert.ToInt32(hdd));

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Додано успішно!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
