namespace TemelAracKullanimlari
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnArttir = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnAzalt = new System.Windows.Forms.Button();
            this.PrgBarislem1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrgBarislem2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.PrgBarislem3 = new System.Windows.Forms.ProgressBar();
            this.BtnBaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(49, 25);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Bolge";
            series6.YValuesPerPoint = 2;
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(343, 274);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // BtnArttir
            // 
            this.BtnArttir.Location = new System.Drawing.Point(459, 86);
            this.BtnArttir.Name = "BtnArttir";
            this.BtnArttir.Size = new System.Drawing.Size(75, 25);
            this.BtnArttir.TabIndex = 1;
            this.BtnArttir.Text = "Arttır";
            this.BtnArttir.UseVisualStyleBackColor = true;
            this.BtnArttir.Click += new System.EventHandler(this.BtnArttir_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 317);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(408, 41);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 60;
            // 
            // BtnAzalt
            // 
            this.BtnAzalt.Location = new System.Drawing.Point(459, 115);
            this.BtnAzalt.Name = "BtnAzalt";
            this.BtnAzalt.Size = new System.Drawing.Size(75, 25);
            this.BtnAzalt.TabIndex = 3;
            this.BtnAzalt.Text = "Azalt";
            this.BtnAzalt.UseVisualStyleBackColor = true;
            this.BtnAzalt.Click += new System.EventHandler(this.BtnAzalt_Click);
            // 
            // PrgBarislem1
            // 
            this.PrgBarislem1.Location = new System.Drawing.Point(108, 364);
            this.PrgBarislem1.Name = "PrgBarislem1";
            this.PrgBarislem1.Size = new System.Drawing.Size(183, 17);
            this.PrgBarislem1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "İşlem 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "İşlem 2:";
            // 
            // PrgBarislem2
            // 
            this.PrgBarislem2.Location = new System.Drawing.Point(108, 387);
            this.PrgBarislem2.Name = "PrgBarislem2";
            this.PrgBarislem2.Size = new System.Drawing.Size(183, 17);
            this.PrgBarislem2.TabIndex = 6;
            this.PrgBarislem2.Click += new System.EventHandler(this.PrgBarislem2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "İşlem 3:";
            // 
            // PrgBarislem3
            // 
            this.PrgBarislem3.Location = new System.Drawing.Point(108, 410);
            this.PrgBarislem3.Name = "PrgBarislem3";
            this.PrgBarislem3.Size = new System.Drawing.Size(183, 17);
            this.PrgBarislem3.TabIndex = 8;
            // 
            // BtnBaslat
            // 
            this.BtnBaslat.Location = new System.Drawing.Point(459, 258);
            this.BtnBaslat.Name = "BtnBaslat";
            this.BtnBaslat.Size = new System.Drawing.Size(75, 25);
            this.BtnBaslat.TabIndex = 10;
            this.BtnBaslat.Text = "Başlat";
            this.BtnBaslat.UseVisualStyleBackColor = true;
            this.BtnBaslat.Click += new System.EventHandler(this.BtnBaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBaslat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrgBarislem3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrgBarislem2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrgBarislem1);
            this.Controls.Add(this.BtnAzalt);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnArttir);
            this.Controls.Add(this.chart1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BtnArttir;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnAzalt;
        private System.Windows.Forms.ProgressBar PrgBarislem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar PrgBarislem2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar PrgBarislem3;
        private System.Windows.Forms.Button BtnBaslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}