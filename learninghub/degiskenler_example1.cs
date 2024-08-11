/* namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Merhaba Dunya");

            Console.Read();        }
     }
*/
/*
namespace Kimlik_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Kimlik ********");
            Console.WriteLine();
            Console.Write("Adile");
            Console.Write("Akkılıç");
            Console.WriteLine("XXXXXXX");
            Console.WriteLine("Bursa Teknik Üniversitesi");
            Console.Write("Elazığ");
            Console.Read();
        }
    }
}
*/
/*
using System.Reflection.Metadata;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            string sehir ,ilce;
            sehir = "Bursa";
            ilce = "Nilüfer";
            Console.Write(sehir +" "+ ilce);
            // Console.Write(sehir);

            Console.Read();
        }
    }
}
*/
/*
namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            sayi = 24;
            Console.Write(sayi);
            
            int sayi1, sayi2, toplam;
            sayi1 = 12;
            sayi2 = 23;
            toplam = sayi1 + sayi2;
            Console.Write(toplam);

            Console.Read();
        }
    }
}
*/
/*
namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int kisa, uzun, alan, cevre;
            kisa = 5;
            uzun = 12;
            cevre = kisa + kisa + uzun + uzun;
            alan = kisa * uzun;
            Console.WriteLine("Alani: "+alan);
            Console.WriteLine("Cevre uzunlugu: "+cevre);

            Console.Read();
        }
    }
}
*/
/*
namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, toplam, carpim, bolum, fark;

            Console.WriteLine("***Aritmetik İşlemler***");
            Console.WriteLine();
            s1 = 23;
            s2 = 5;
            toplam = s1 + s2;
            fark = s1 - s2;
            carpim = s1 * s2;
            bolum = s1 / s2;
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Fark: " + fark);
            Console.WriteLine("Carpim: " + carpim);
            Console.WriteLine("Bölüm: " + bolum);
            Console.WriteLine();
            Console.WriteLine("***Aritmetik İşlemler***");

            Console.Read();
        }
    }
}
*/
/*
namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, bolum, ders;
            int s1, s2, s3, ort;

            //string degiskenlerinin atamaları
            ad = "Adile";
            soyad = "Akkılıç";
            bolum = "Bilgisayar Mühendisliği";
            ders = "c#";

            //Int değişkenlerin atamaları
            s1 = 78;
            s2 = 83;
            s3 = 90;
            ort = (s1 + s2 + s3) / 3;

            //Yazdırma Komutları
            Console.WriteLine("***Öğrenci Bilgi Sistemi***");
            Console.WriteLine();
            Console.WriteLine("Öğrenci Adı soyadı: " + ad + "" + soyad);
            Console.WriteLine("Bölüm" + bolum);
            Console.WriteLine("Ders: " + ders);
            Console.WriteLine();
            Console.WriteLine("Sınav 1:" + s1);
            Console.WriteLine("Sınav 2:" + s2);
            Console.WriteLine("Sınav 3:" + s3);
            Console.WriteLine("Ortalamanız: " + ort);
            Console.Read();
        }
    }
}
*/
/*
namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //double sayi;
            //sayi = 23.23;
            //Console.Write(sayi);

            double s1 ,s2, ort;
            s1=25;
            s2 = 23;
            ort = (s1 + s2) / 2;
            Console.Write(ort);

            Console.Read();
        }
    }
}
*/
/*
namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            string şehir, ilçe ;
            Console.Write("Lütfen şehrinizi giriniz: ");
            şehir = Console.ReadLine();
            Console.Write("Lütfen ilçenizi giriniz: ");
            ilçe = Console.ReadLine();
            Console.WriteLine("Girdiğiniz şehir: " + şehir+ " "+ilçe);

            Console.Read();
        }
    }
}
*/
/*
namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayıyı giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());
            Console.Write(sayi);
            int s1, s2, toplam;
            Console.Write("Sayı 1: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayı 2: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            toplam = s1 + s2;
            Console.Write(toplam);
            Console.Read();
        }
    }
}
*/
/*
namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int kisa, uzun, cevre, alan;
            Console.Write("Kısa kenar: ");
            kisa = Convert.ToInt16(Console.ReadLine());
            Console.Write("Uzun kenar: ");
            uzun = Convert.ToInt16(Console.ReadLine());
            alan = kisa * uzun;
            cevre = kisa + kisa + uzun + uzun;
            Console.WriteLine("Alanı: " + alan);
            Console.WriteLine("Çevresi: " + cevre);
            Console.Read();
        }
    }
}
*/
/*
namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, toplam, fark, carpim, bolum;
            Console.Write("Sayı 1: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayı 2: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            toplam = s1 + s2;
            fark = s1 - s2;
            carpim = s1 * s2;
            bolum = s1 / s2;
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Fark: " + fark);
            Console.WriteLine("Çarpım: " + carpim);
            Console.WriteLine("Bölüm: " + bolum);

            Console.Read();

        }
    }
}
*/
/*
namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1,s2,toplam;
            Console.Write("Sayı 1'i giriniz: ");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayı 2'yi giriniz: ");
            s2 = Convert.ToDouble(Console.ReadLine());
            toplam = s1 + s2;
            Console.Write("Sonuç: " + toplam);

            Console.WriteLine();
            Console.Read();
        }
    }
}
*/










