﻿namespace TemelAracKullanimlari
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtOrtalama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCizgi = new System.Windows.Forms.Button();
            this.BtnSayac = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnMesajKutusu = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.BtnForDongusu = new System.Windows.Forms.Button();
            this.BtnForDongusu2 = new System.Windows.Forms.Button();
            this.BtnListboxTemizle = new System.Windows.Forms.Button();
            this.BtnWhile = new System.Windows.Forms.Button();
            this.BtnDizi1 = new System.Windows.Forms.Button();
            this.BtnDizi2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(163, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Not Kayıt Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(110, 81);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(178, 31);
            this.TxtAdSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ders: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Biçimsel Diller ve Otomata Teorisi",
            "Mikroişlemciler",
            "Algoritma Analizi ve Tasarımı",
            "Sunucu İşletim Sistemleri  ",
            "İşletim Sistemleri",
            "Yazılım Mühendisliği",
            "Bilgisayar Ağları"});
            this.comboBox1.Location = new System.Drawing.Point(110, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(380, 81);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(59, 31);
            this.TxtSinav1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sınav 1: ";
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(380, 115);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(59, 31);
            this.TxtSinav2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sınav 2: ";
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Location = new System.Drawing.Point(380, 155);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(59, 31);
            this.TxtSinav3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sınav 3: ";
            // 
            // TxtOrtalama
            // 
            this.TxtOrtalama.Enabled = false;
            this.TxtOrtalama.Location = new System.Drawing.Point(545, 84);
            this.TxtOrtalama.Name = "TxtOrtalama";
            this.TxtOrtalama.Size = new System.Drawing.Size(59, 31);
            this.TxtOrtalama.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ortalama: ";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(12, 204);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(103, 43);
            this.BtnKaydet.TabIndex = 13;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(121, 204);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(103, 43);
            this.BtnHesapla.TabIndex = 14;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(230, 204);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(108, 43);
            this.BtnTemizle.TabIndex = 15;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(25, 298);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(486, 129);
            this.listBox1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Numara: ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(111, 160);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(174, 31);
            this.maskedTextBox1.TabIndex = 18;
            // 
            // TxtDurum
            // 
            this.TxtDurum.Enabled = false;
            this.TxtDurum.Location = new System.Drawing.Point(545, 123);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(59, 31);
            this.TxtDurum.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Durum: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(627, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCizgi
            // 
            this.BtnCizgi.Location = new System.Drawing.Point(344, 204);
            this.BtnCizgi.Name = "BtnCizgi";
            this.BtnCizgi.Size = new System.Drawing.Size(108, 43);
            this.BtnCizgi.TabIndex = 22;
            this.BtnCizgi.Text = "Çizgi";
            this.BtnCizgi.UseVisualStyleBackColor = true;
            this.BtnCizgi.Click += new System.EventHandler(this.BtnCizgi_Click);
            // 
            // BtnSayac
            // 
            this.BtnSayac.Location = new System.Drawing.Point(458, 204);
            this.BtnSayac.Name = "BtnSayac";
            this.BtnSayac.Size = new System.Drawing.Size(108, 43);
            this.BtnSayac.TabIndex = 23;
            this.BtnSayac.Text = "Sayaç";
            this.BtnSayac.UseVisualStyleBackColor = true;
            this.BtnSayac.Click += new System.EventHandler(this.BtnSayac_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "label10";
            // 
            // BtnMesajKutusu
            // 
            this.BtnMesajKutusu.Location = new System.Drawing.Point(572, 204);
            this.BtnMesajKutusu.Name = "BtnMesajKutusu";
            this.BtnMesajKutusu.Size = new System.Drawing.Size(130, 43);
            this.BtnMesajKutusu.TabIndex = 25;
            this.BtnMesajKutusu.Text = "Mesaj Kutusu";
            this.BtnMesajKutusu.UseVisualStyleBackColor = true;
            this.BtnMesajKutusu.Click += new System.EventHandler(this.BtnMesajKutusu_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(25, 442);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(486, 129);
            this.listBox2.TabIndex = 26;
            // 
            // BtnForDongusu
            // 
            this.BtnForDongusu.Location = new System.Drawing.Point(10, 249);
            this.BtnForDongusu.Name = "BtnForDongusu";
            this.BtnForDongusu.Size = new System.Drawing.Size(130, 43);
            this.BtnForDongusu.TabIndex = 27;
            this.BtnForDongusu.Text = "For Döngüsü";
            this.BtnForDongusu.UseVisualStyleBackColor = true;
            this.BtnForDongusu.Click += new System.EventHandler(this.BtnForDongusu_Click);
            // 
            // BtnForDongusu2
            // 
            this.BtnForDongusu2.Location = new System.Drawing.Point(146, 249);
            this.BtnForDongusu2.Name = "BtnForDongusu2";
            this.BtnForDongusu2.Size = new System.Drawing.Size(142, 43);
            this.BtnForDongusu2.TabIndex = 28;
            this.BtnForDongusu2.Text = "For Döngüsü 2\r\n";
            this.BtnForDongusu2.UseVisualStyleBackColor = true;
            this.BtnForDongusu2.Click += new System.EventHandler(this.BtnForDongusu2_Click);
            // 
            // BtnListboxTemizle
            // 
            this.BtnListboxTemizle.Location = new System.Drawing.Point(294, 249);
            this.BtnListboxTemizle.Name = "BtnListboxTemizle";
            this.BtnListboxTemizle.Size = new System.Drawing.Size(139, 43);
            this.BtnListboxTemizle.TabIndex = 29;
            this.BtnListboxTemizle.Text = "Listbox Temizle";
            this.BtnListboxTemizle.UseVisualStyleBackColor = true;
            this.BtnListboxTemizle.Click += new System.EventHandler(this.BtnListboxTemizle_Click);
            // 
            // BtnWhile
            // 
            this.BtnWhile.Location = new System.Drawing.Point(439, 249);
            this.BtnWhile.Name = "BtnWhile";
            this.BtnWhile.Size = new System.Drawing.Size(150, 43);
            this.BtnWhile.TabIndex = 30;
            this.BtnWhile.Text = "While Döngüsü";
            this.BtnWhile.UseVisualStyleBackColor = true;
            this.BtnWhile.Click += new System.EventHandler(this.BtnWhile_Click);
            // 
            // BtnDizi1
            // 
            this.BtnDizi1.Location = new System.Drawing.Point(595, 249);
            this.BtnDizi1.Name = "BtnDizi1";
            this.BtnDizi1.Size = new System.Drawing.Size(108, 43);
            this.BtnDizi1.TabIndex = 31;
            this.BtnDizi1.Text = "Dizi 1";
            this.BtnDizi1.UseVisualStyleBackColor = true;
            this.BtnDizi1.Click += new System.EventHandler(this.BtnDizi1_Click);
            // 
            // BtnDizi2
            // 
            this.BtnDizi2.Location = new System.Drawing.Point(532, 298);
            this.BtnDizi2.Name = "BtnDizi2";
            this.BtnDizi2.Size = new System.Drawing.Size(108, 43);
            this.BtnDizi2.TabIndex = 32;
            this.BtnDizi2.Text = "Dizi 2";
            this.BtnDizi2.UseVisualStyleBackColor = true;
            this.BtnDizi2.Click += new System.EventHandler(this.BtnDizi2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 703);
            this.Controls.Add(this.BtnDizi2);
            this.Controls.Add(this.BtnDizi1);
            this.Controls.Add(this.BtnWhile);
            this.Controls.Add(this.BtnListboxTemizle);
            this.Controls.Add(this.BtnForDongusu2);
            this.Controls.Add(this.BtnForDongusu);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.BtnMesajKutusu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnSayac);
            this.Controls.Add(this.BtnCizgi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtDurum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtOrtalama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSinav3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSinav2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSinav1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtOrtalama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCizgi;
        private System.Windows.Forms.Button BtnSayac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnMesajKutusu;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button BtnForDongusu;
        private System.Windows.Forms.Button BtnForDongusu2;
        private System.Windows.Forms.Button BtnListboxTemizle;
        private System.Windows.Forms.Button BtnWhile;
        private System.Windows.Forms.Button BtnDizi1;
        private System.Windows.Forms.Button BtnDizi2;
    }
}