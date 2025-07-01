using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComputerStore
{
    public partial class Delete : Form
    {
        private string connectionString = "server=localhost;user=root;password=10011111Ok;database=laba3;";

        public Delete()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text.Trim() == "")
            {
                MessageBox.Show("Введіть ID запису для видалення.");
                return;
            }

            int id;
            if (!int.TryParse(textBoxId.Text.Trim(), out id))
            {
                MessageBox.Show("ID має бути цілим числом.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM computers WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Запис успішно видалено.");
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
