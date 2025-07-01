using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComputerStore
{
    public partial class Change : Form
    {
        private string connectionString = "server=localhost;user=root;password=10011111Ok;database=laba3;";

        public Change()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBoxId.Text.Trim(), out id))
            {
                MessageBox.Show("ID має бути цілим числом.");
                return;
            }

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
                    string query = @"UPDATE computers SET 
                                        name = @name,
                                        cpu_type = @cpu_type,
                                        cpu_speed = @cpu_speed,
                                        gpu = @gpu,
                                        cd_type = @cd_type,
                                        sound_card = @sound_card,
                                        hdd_size = @hdd_size
                                     WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@cpu_type", cpuType);
                        cmd.Parameters.AddWithValue("@cpu_speed", Convert.ToDecimal(cpuSpeed));
                        cmd.Parameters.AddWithValue("@gpu", gpu);
                        cmd.Parameters.AddWithValue("@cd_type", cdType);
                        cmd.Parameters.AddWithValue("@sound_card", sound);
                        cmd.Parameters.AddWithValue("@hdd_size", Convert.ToInt32(hdd));

                        int affected = cmd.ExecuteNonQuery();
                        if (affected > 0)
                            MessageBox.Show("Запис оновлено!");
                        else
                            MessageBox.Show("Запис із таким ID не знайдено.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
