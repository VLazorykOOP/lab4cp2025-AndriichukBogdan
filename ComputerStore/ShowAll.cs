using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComputerStore
{
    public partial class ShowAll : Form
    {
        private string connectionString = "server=localhost;user=root;password=10011111Ok;database=laba3;";

        public ShowAll()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM computers";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка з'єднання з БД: " + ex.Message);
            }
        }
    }
}
