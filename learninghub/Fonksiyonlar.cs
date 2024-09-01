/*
namespace Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math
            double sayi;
            Console.Write("Sayıyı giriniz: ");
            sayi= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mutlak Değer: " + Math.Abs(sayi));
            Console.WriteLine("Üst taban: "+ Math.Ceiling(sayi));
            Console.WriteLine("Alt taban: " + Math.Floor(sayi));
            Console.WriteLine("Karekökü: "+ Math.Sqrt(sayi));
            Console.Read();
        }
    }
}
*/
/*
namespace Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metinsel fonksiyonlar
            string metin, metin2;
            Console.Write("Metni giriniz: ");
            metin = Console.ReadLine();
            Console.Write("Metni giriniz: ");
            metin2 = Console.ReadLine();

            Console.WriteLine("Concat şile birleştirme: "+string.Concat(metin, metin2));
            Console.WriteLine("Metin1 için karakter sayısı: " + metin.Length);
            Console.WriteLine("Indexof örnek: " + metin.IndexOf("selam"));
            Console.WriteLine("Startswith örnek: " + metin.StartsWith("merhaba"));
            Console.WriteLine("Büyük Harf: "+metin.ToUpper());
            Console.WriteLine("Küçük Harf: "+metin.ToLower());
            Console.WriteLine("Remove metodu: "+metin.Remove(3));
            Console.WriteLine("Replace fonksiyonu: " + metin.Replace("a", "A"));
            Console.WriteLine("Substring fonksiyonu: "+metin.Substring(3));
            Console.ReadLine();
        }
    }
}
*/
/*
namespace Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime
            Console.WriteLine("Şuan saat: " + DateTime.Now.Hour);
            Console.WriteLine("Şuan saat: " + DateTime.Now.Minute);
            Console.WriteLine("Şuan saat: " + DateTime.Now.Second);

            Console.WriteLine("Bugünün gün bilgisi: "+ DateTime.Now.Day);
            Console.WriteLine("Bugünün ay bilgisi: "+ DateTime.Now.Month);
            Console.WriteLine("Bugünün yıl bilgisi: "+ DateTime.Now.Year);
            Console.WriteLine("Bugünün kısa tarihi: "+ DateTime.Now.ToShortDateString());
            Console.WriteLine("Bugünün kısa tarihi: " + DateTime.Now.ToLongDateString());

            Console.Read();
        }
    }
}
*/
namespace Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan
            TimeSpan zaman;
            int gunfarki;
            DateTime tarih1, tarih2;
            tarih1 = Convert.ToDateTime("01.12.2020");
            tarih2 = Convert.ToDateTime("15.12.2020");
            zaman = tarih2 - tarih1;
            gunfarki = zaman.Days;
            Console.WriteLine("Farkı: " + gunfarki);

            Console.Read();
        }
    }
}
