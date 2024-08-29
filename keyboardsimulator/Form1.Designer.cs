namespace odev6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Keyboard Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

            // Butonları oluşturma ve ekleme işlemleri
            CreateButtons();
        }

        private void CreateButtons()
        {
            string[] keys = { "Q","W","E","R","T","Y","U","I","O","P","F","A", "S", "D","G","H","J","K","L","M", "N","B","V","C","X","Z", "Space", "Enter", "Shift", "Ctrl" };
            int x = 10, y = 10;

            foreach (var key in keys)
            {
                Button button = new Button();
                button.Name = key;
                button.Text = key;
                button.Width = 50;
                button.Height = 50;
                button.Location = new System.Drawing.Point(x, y);

                panel1.Controls.Add(button);

                x += 60; // Butonlar arasında boşluk bırakmak için x'i artırıyoruz

                if (x > 400) // Panelin sınırlarını aşarsa yeni satıra geç
                {
                    x = 10;
                    y += 60;
                }
            }
        }
    }
}
