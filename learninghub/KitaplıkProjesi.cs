using System.IO;
namespace KitaplıkProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplamfiyat = 0;
            string secim;
            Console.WriteLine("******************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**      Türkçe Kitaplar Kategorisi      **   Yabancı Kitaplar Kategorisi    **");
            Console.WriteLine();
            Console.WriteLine("** 1-Çalıkuşu: Reşat Nuri               ** 7-Tuna Kılavuzu: Jules Verne     **");
            Console.WriteLine();
            Console.WriteLine("** 2-Yalnızız: Peyami Safa              ** 8-Dönüşüm: Franz Kafka           **");
            Console.WriteLine();
            Console.WriteLine("** 3-Eylül: Mehmet Rauf                 ** 9-Bülbülü Öldürmek: Harper Lee   **");
            Console.WriteLine();
            Console.WriteLine("** 4-Serenad: Zülfü Livaneli            ** 10-Beyaz Diş: Jack London        **");
            Console.WriteLine();
            Console.WriteLine("** 5-İçimizdeki Şeytan: Sabahattin Ali  ** 11-Gurur ve Önyargı: Jane Austen **");
            Console.WriteLine();
            Console.WriteLine("** 6-Aşk-ı Memnu: Halit Ziya Uşaklıgil  ** 12-Devlet: Platon                **");
            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine();
            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.WriteLine("Yapmak istediğiniz işlemin numarası: ");
            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if (islem == '1')
            {
                Console.WriteLine();
                Console.Write("Lütfen fiyatını öğrenmek istediğiniz kitabın numarasını giriniz:");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1": Console.Write("Çalıkuşu: 402 TL"); break;
                    case "2": Console.Write("Yalnızız: 219 TL"); break;
                    case "3": Console.Write("Eylül: 155 TL"); break;
                    case "4": Console.Write("Serenad: 379 TL"); break;
                    case "5": Console.Write("İçimizdeki Şeytan: 58 TL"); break;
                    case "6": Console.Write("Aşk-ı Memnu: 190 TL"); break;
                    case "7": Console.Write("Tuna Kılavuzu: 43 TL"); break;
                    case "8": Console.Write("Dönüşüm: 75 TL"); break;
                    case "9": Console.Write("Bülbülü Öldürmek: 132 TL"); break;
                    case "10": Console.Write("Beyaz Diş: 90 TL"); break;
                    case "11": Console.Write("Gurur ve Önyargı: 130 TL"); break;
                    case "12": Console.Write("Devlet: 100 TL"); break;
                    default: Console.Write("Bulunmayan kitap :("); break;
                }
            }
            if (islem == '2')
            {
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, okul;
                Console.Write("Adınız: ");
                ad = Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyad = Console.ReadLine();
                Console.Write("Okulunuz: ");
                okul = Console.ReadLine();

                string dosya = @"C:\Users\user\Desktop\Okurlar.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyadınız: " + soyad);
                sw.WriteLine("Okulunuz: " + okul);
                sw.Close();
            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("******************************");
                Console.WriteLine();
                Console.WriteLine("Bugünün Kitabı: Çalıkuşu");
                Console.WriteLine();
                Console.WriteLine("******************************");
            }
            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("******************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\user\Desktop\Okurlar.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr= new StreamReader(fs);
                string metin =sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                Console.WriteLine();
                Console.WriteLine("******************************");
            }
            if (islem == '5')
            {
                for (int i = 1; i <= 100; i++) {
                    Console.WriteLine();
                    Console.Write("Seçtiğiniz kitabın numarası: ");
                    secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        toplamfiyat = toplamfiyat + 402;
                    }
                    else if(secim=="2") 
                    {
                        toplamfiyat = toplamfiyat + 219;
                    }
                    else if (secim == "3")
                    {
                        toplamfiyat = toplamfiyat + 155;
                    }
                    else if (secim == "4")
                    {
                        toplamfiyat = toplamfiyat + 379;
                    }
                    else if (secim == "5")
                    {
                        toplamfiyat = toplamfiyat + 58;
                    }
                    else if (secim == "6")
                    {
                        toplamfiyat = toplamfiyat + 190;
                    }
                    else if (secim == "7")
                    {
                        toplamfiyat = toplamfiyat + 43;
                    }
                    else if (secim == "8")
                    {
                        toplamfiyat = toplamfiyat + 75;
                    }
                    else if (secim == "9")
                    {
                        toplamfiyat = toplamfiyat + 132;
                    }
                    else if (secim == "10")
                    {
                        toplamfiyat = toplamfiyat + 90;
                    }
                    else if (secim == "11")
                    {
                        toplamfiyat = toplamfiyat + 130;
                    }
                    else if (secim == "12")
                    {
                        toplamfiyat = toplamfiyat + 100;
                    }
                    else
                    
                        Console.WriteLine("böyle bir kitap yok");
                        Console.WriteLine();
                        Console.WriteLine("Başka bir kitap ister misiniz: ");
                        string cevap= Console.ReadLine();
                        if (cevap == "h" || cevap == "H" || cevap == "hayır" || cevap == "HAYIR")
                            break;
                    
                }
                Console.WriteLine("Toplam tutar: " + toplamfiyat);
            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd= new Random();
                int sayi=rnd.Next(1,100);
                while(sayi!=tahmin)
                {
                    Console.Write("Sayı Giriniz: ");
                    tahmin=Convert.ToInt32(Console.ReadLine());
                    if (tahmin > sayi)
                    {
                        Console.Write("Daha Küçük");
                    }
                    if (tahmin < sayi)
                    {
                        Console.Write("Daha Büyük");
                    }
                    if (tahmin == sayi)
                    {
                        Console.Write("Bildiniz");
                        break;
                    }
                }
            }

            Console.Read();
        }
    }
}







