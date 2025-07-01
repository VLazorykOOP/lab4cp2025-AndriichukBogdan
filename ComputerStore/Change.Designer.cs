namespace ComputerStore
{
    partial class Change
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxId, textBoxName, textBoxCPUType, textBoxCPUSpeed, textBoxGPU, textBoxCD, textBoxSound, textBoxHDD;
        private Button buttonUpdate;
        private Label[] labels;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxId = new TextBox();
            this.textBoxName = new TextBox();
            this.textBoxCPUType = new TextBox();
            this.textBoxCPUSpeed = new TextBox();
            this.textBoxGPU = new TextBox();
            this.textBoxCD = new TextBox();
            this.textBoxSound = new TextBox();
            this.textBoxHDD = new TextBox();
            this.buttonUpdate = new Button();

            this.labels = new Label[8];
            string[] labelTexts = {
                "ID (для редагування):", "Назва комп'ютера:", "Тип процесора:", "Тактова частота:",
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
                textBoxId, textBoxName, textBoxCPUType, textBoxCPUSpeed,
                textBoxGPU, textBoxCD, textBoxSound, textBoxHDD
            };

            for (int i = 0; i < textboxes.Length; i++)
            {
                textboxes[i].Location = new System.Drawing.Point(220, 30 + i * 40);
                textboxes[i].Size = new System.Drawing.Size(200, 31);
                this.Controls.Add(textboxes[i]);
            }

            this.buttonUpdate.Location = new System.Drawing.Point(150, 370);
            this.buttonUpdate.Size = new System.Drawing.Size(150, 40);
            this.buttonUpdate.Text = "Оновити";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            this.Controls.Add(this.buttonUpdate);

            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Name = "Change";
            this.Text = "Редагування комп'ютера";
        }
    }
}
