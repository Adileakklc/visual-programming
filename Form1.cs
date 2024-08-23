using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudentInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightCyan; // Formun arka plan rengini ayarlayın
            groupBox1.BackColor = System.Drawing.Color.LemonChiffon; // GroupBox arka plan rengini ayarlayın
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcı girişlerini al
                string name = txtName.Text;
                string surname = txtSurname.Text;
                double kilo = double.Parse(txtWeight.Text);
                double boy = double.Parse(txtHeight.Text);
                DateTime dogumTarihi = DateTime.ParseExact(txtBirthDate.Text, "dd/MM/yyyy", null);

                // Doğum tarihini çözümle
                string gun = GunIsmiTurkce(dogumTarihi.DayOfWeek.ToString());
                string ayAdi = dogumTarihi.ToString("MMMM");
                int yil = dogumTarihi.Year;

                // VKİ Hesapla (Vücut Kitle İndeksi)
                double boyMetre = boy / 100;
                double vki = kilo / (boyMetre * boyMetre);

                // Burç belirle
                string burc = BurcHesapla(dogumTarihi);

                // ListBox'ları temizle
                listBox4.Items.Clear();
                listBox7.Items.Clear();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox5.Items.Clear();
                listBox6.Items.Clear();

                // ListBox'ları doldur
                listBox4.Items.Add(name);
                listBox7.Items.Add(surname);
                listBox1.Items.Add(gun);
                listBox2.Items.Add(ayAdi);
                listBox3.Items.Add(yil.ToString());
                listBox5.Items.Add(vki.ToString("0.00"));
                listBox6.Items.Add(burc);

                // Burç Resmi ve Yorumu göster
                pictureBoxZodiac.Image = BurcResmi(burc);
                txtComment.Text = BurcYorumu(burc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void txtBirthDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Doğum tarihi kontrolü, henüz tam bir tarih girilmediyse işlem yapma
                if (txtBirthDate.MaskCompleted)
                {
                    DateTime dogumTarihi = DateTime.ParseExact(txtBirthDate.Text, "dd/MM/yyyy", null);
                    string burc = BurcHesapla(dogumTarihi);

                    // Burç ListBox'ını temizle ve yeni burcu ekle
                    listBox6.Items.Clear();
                    listBox6.Items.Add(burc);
                }
            }
            catch (Exception ex)
            {
                // Geçersiz tarih formatı durumunda
                MessageBox.Show("Hata: Geçersiz tarih formatı. Lütfen geçerli bir tarih girin.");
            }
        }

        private string BurcYorumu(string burc)
        {
            var burcYorumlari = new Dictionary<string, string>{
                { "Koç", "Koç burcu, enerjik, cesur ve lider ruhludur. Atılgan ve kararlı olmalarıyla bilinirler, genellikle öne çıkarlar ve inisiyatif alırlar. Sabırsız ve aceleci olabilirler, ancak kararlılıkları ve azimleri sayesinde hedeflerine ulaşırlar." },
                { "Boğa", "Boğa burcu, sabırlı, güvenilir ve kararlıdır. Pratik bir yaklaşımla hareket ederler ve istikrarlı olmayı tercih ederler. Maddi güvence ve rahatlık onlar için önemlidir. Boğa burçları bazen inatçı olabilir, ancak sadakatleri ve kararlılıkları onları güvenilir bir arkadaş yapar." },
                { "İkizler", "İkizler burcu, zeki, meraklı ve iletişim odaklıdır. Sosyal ve konuşkan yapılarıyla dikkat çekerler, yeni bilgiler ve deneyimler ararlar. Değişken ve uyumlu bir yapıya sahiptirler, ancak bazen kararsız olabilirler." },
                { "Yengeç", "Yengeç burcu, duygusal, koruyucu ve sezgiseldir. Aile ve ev yaşamına büyük önem verirler, sevdiklerine bağlıdırlar. Yengeçler, empati kurma yetenekleriyle tanınır, ancak zaman zaman aşırı duyarlı olabilirler." },
                { "Aslan", "Aslan burcu, karizmatik, yaratıcı ve lider ruhludur. Kendine güvenen ve etkileyici bir yapıya sahiptirler, ilgi odağı olmayı severler. Aslanlar cömerttir, ancak bazen kibirli ve egoist olabilirler." },
                { "Başak", "Başak burcu, titiz, analitik ve çalışkandır. Detaylara önem verir ve mükemmeliyetçi bir yapıya sahiptirler. Başaklar pratik çözümler üretme konusunda iyidir, ancak eleştirel olabilirler." },
                { "Terazi", "Terazi burcu, adaletli, uyumlu ve estetik değerlere önem veren bir karaktere sahiptir. İlişkilerde dengeyi ararlar ve diplomasi konusunda yeteneklidirler. Terazi burçları bazen kararsız olabilir, ancak sosyal becerileri güçlüdür." },
                { "Akrep", "Akrep burcu, tutkulu, gizemli ve güçlü bir iradeye sahiptir. Derinlemesine düşünen ve güçlü bir sezgiye sahip olan Akrepler, aynı zamanda kararlı ve azimlidirler. Ancak, intikamcı ve kıskanç olabilirler." },
                { "Yay", "Yay burcu, özgür ruhlu, maceracı ve iyimserdir. Keşfetmeyi ve öğrenmeyi severler, geniş bir dünya görüşüne sahiptirler. Yay burçları, bazen düşüncesiz veya sabırsız olabilirler, ancak enerjik ve neşeli bir yapıları vardır." },
                { "Oğlak", "Oğlak burcu, disiplinli, sorumlu ve kararlıdır. Hedeflerine ulaşmak için planlı bir şekilde çalışırlar, ciddiyetleri ve azimleri ile tanınırlar. Oğlaklar bazen soğuk ve mesafeli görünebilir, ancak sadık ve güvenilirdirler." },
                { "Kova", "Kova burcu, yenilikçi, bağımsız ve orijinaldir. Özgün fikirleri ve insani değerlere verdikleri önemle bilinirler. Kova burçları, sosyal değişimlere öncülük etmekten hoşlanır, ancak bazen uzak ve soğuk olabilirler." },
                { "Balık", "Balık burcu, empatik, hayalperest ve sezgiseldir. Sanatsal ve yaratıcı bir doğaya sahiptirler, başkalarının duygularını anlama konusunda güçlüdürler. Balık burçları bazen kararsız ve aşırı duygusal olabilir, ancak fedakarlıkları ve şefkatleri ile bilinirler." }
            };
            return burcYorumlari.TryGetValue(burc, out var yorum) ? yorum : "Yorum bulunamadı.";
        }

        private Image BurcResmi(string burc)
        {
            // Resim dosyalarının yer aldığı dizin
            string path = @"C:\Users\user\source\repos\StudentInfoApp\Images\"; // Resimlerin bulunduğu dizin

            try
            {
                // Burcun adına göre ilgili resmi yükleyip döndür
                switch (burc)
                {
                    case "Koç":
                        return Image.FromFile(Path.Combine(path, "koc.png"));
                    case "Boğa":
                        return Image.FromFile(Path.Combine(path, "boga.png"));
                    case "İkizler":
                        return Image.FromFile(Path.Combine(path, "ikizler.png"));
                    case "Yengeç":
                        return Image.FromFile(Path.Combine(path, "yengec.png"));
                    case "Aslan":
                        return Image.FromFile(Path.Combine(path, "aslan.png"));
                    case "Başak":
                        return Image.FromFile(Path.Combine(path, "basak.png"));
                    case "Terazi":
                        return Image.FromFile(Path.Combine(path, "terazi.png"));
                    case "Akrep":
                        return Image.FromFile(Path.Combine(path, "akrep.png"));
                    case "Yay":
                        return Image.FromFile(Path.Combine(path, "yay.png"));
                    case "Oğlak":
                        return Image.FromFile(Path.Combine(path, "oglak.png"));
                    case "Kova":
                        return Image.FromFile(Path.Combine(path, "kova.png"));
                    case "Balık":
                        return Image.FromFile(Path.Combine(path, "balik.png"));
                    default:
                        return null; // Eğer burç bulunamazsa, boş döner
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Resim yüklenirken bir hata oluştu: " + ex.Message);
                return null;
            }
        }


        private string BurcHesapla(DateTime dogumTarihi)
        {
            int gun = dogumTarihi.Day;
            int ay = dogumTarihi.Month;

            if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20)) return "Koç";
            else if ((ay == 4 && gun >= 21) || (ay == 5 && gun <= 20)) return "Boğa";
            else if ((ay == 5 && gun >= 21) || (ay == 6 && gun <= 21)) return "İkizler";
            else if ((ay == 6 && gun >= 22) || (ay == 7 && gun <= 22)) return "Yengeç";
            else if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 22)) return "Aslan";
            else if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 22)) return "Başak";
            else if ((ay == 9 && gun >= 23) || (ay == 10 && gun <= 22)) return "Terazi";
            else if ((ay == 10 && gun >= 23) || (ay == 11 && gun <= 21)) return "Akrep";
            else if ((ay == 11 && gun >= 22) || (ay == 12 && gun <= 21)) return "Yay";
            else if ((ay == 12 && gun >= 22) || (ay == 1 && gun <= 19)) return "Oğlak";
            else if ((ay == 1 && gun >= 20) || (ay == 2 && gun <= 18)) return "Kova";
            else if ((ay == 2 && gun >= 19) || (ay == 3 && gun <= 20)) return "Balık";
            else return "Bilinmiyor";
        }

        private string GunIsmiTurkce(string Gun)
        {
            switch (Gun)
            {
                case "Monday": return "Pazartesi";
                case "Tuesday": return "Salı";
                // Diğer günler için kodları ekleyin
                default: return "Bilinmiyor";
            }
        }

        private void lblYil_Click(object sender, EventArgs e)
        {

        }
    }
}
