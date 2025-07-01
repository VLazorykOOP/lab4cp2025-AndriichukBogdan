namespace ComputerStore
{
    partial class Delete
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxId;
        private Button buttonDelete;
        private Label label;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxId = new TextBox();
            this.buttonDelete = new Button();
            this.label = new Label();

            // 
            // label
            // 
            this.label.Text = "Введіть ID комп’ютера для видалення:";
            this.label.Location = new System.Drawing.Point(30, 30);
            this.label.AutoSize = true;

            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(30, 70);
            this.textBoxId.Size = new System.Drawing.Size(250, 31);

            // 
            // buttonDelete
            // 
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.Location = new System.Drawing.Point(100, 120);
            this.buttonDelete.Size = new System.Drawing.Size(120, 40);
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);

            // 
            // Delete
            // 
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonDelete);
            this.Name = "Delete";
            this.Text = "Видалити комп’ютер";
        }
    }
}
