namespace ComputerStore
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAll showAll = new ShowAll();
            showAll.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Change change = new Change();   
            change.Show();
        }
    }
}
