namespace ComputerStore
{
    partial class Add
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonAdd;
        private TextBox textBoxName;
        private TextBox textBoxCPUType;
        private TextBox textBoxCPUSpeed;
        private TextBox textBoxGPU;
        private TextBox textBoxCD;
        private TextBox textBoxSound;
        private TextBox textBoxHDD;
        private Label[] labels;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonAdd = new Button();
            this.textBoxName = new TextBox();
            this.textBoxCPUType = new TextBox();
            this.textBoxCPUSpeed = new TextBox();
            this.textBoxGPU = new TextBox();
            this.textBoxCD = new TextBox();
            this.textBoxSound = new TextBox();
            this.textBoxHDD = new TextBox();

            this.labels = new Label[7];
            string[] labelTexts = {
                "Назва комп'ютера:", "Тип процесора:", "Тактова частота :",
                "Відеокарта:", "Тип CD-приводу:", "Звукова карта:", "Обсяг HDD (GB):"
            };

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = labelTexts[i];
                labels[i].Location = new System.Drawing.Point(30, 30 + i * 40);
                labels[i].AutoSize = true;
                this.Controls.Add(labels[i]);
            }

            TextBox[] textboxes = {
                textBoxName, textBoxCPUType, textBoxCPUSpeed,
                textBoxGPU, textBoxCD, textBoxSound, textBoxHDD
            };

            for (int i = 0; i < textboxes.Length; i++)
            {
                textboxes[i].Location = new System.Drawing.Point(200, 30 + i * 40);
                textboxes[i].Size = new System.Drawing.Size(200, 31);
                this.Controls.Add(textboxes[i]);
            }

            this.buttonAdd.Location = new System.Drawing.Point(150, 330);
            this.buttonAdd.Size = new System.Drawing.Size(120, 40);
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.Controls.Add(this.buttonAdd);

            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Name = "Add";
            this.Text = "Додати комп'ютер";
        }
    }
}
