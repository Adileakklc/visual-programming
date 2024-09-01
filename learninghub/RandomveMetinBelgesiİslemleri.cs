/*
namespace RandomVeMetinBelgesiİslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random sınıfı uygulaması
            //int sayi, sayi2; ;
            //Random r = new Random();
            //sayi = r.Next(0, 23);
            //sayi2 = r.Next(0, 23);

            //Console.WriteLine(sayi+" "+sayi2);

            Random rn = new Random();
            int sehir;
            string[] sehirler = { "Adana", "Ankara", "Ağrı", "Bursa" };
            sehir= rn.Next(0,sehirler.Length);
            Console.WriteLine(sehirler[sehir]);
            Console.Read();
        }
    }
}
*/
/*
namespace RandomVeMetinBelgesiİslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Captcha
            int d1,d2,d3,d4;
            Random rnd= new Random();
            d1 = rnd.Next(0,10);
            d2 = rnd.Next(0, 10);
            d3 = rnd.Next(0, 10);
            d4 = rnd.Next(0, 10);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            string[] karakterler = { "a", "A", "b", "B", "c", "C", "d", "D", "E", "e" };
            Console.Write(d1+karakterler[d2] + d3 + karakterler[d4]);

            Console.Read();
        }
    }
}
*/
using System.IO;
/*
namespace RandomVeMetinBelgesiİslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\user\\Desktop\\deneme.txt");
            sw.Write("Merhaba txt dosyası");
            sw.Close();
            Console.Read();
        }
    }
}
*/
/*
namespace RandomVeMetinBelgesiİslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\user\\Desktop\\deneme2.txt");
            string metin;
            Console.WriteLine("Metni Giriniz: ");
            metin = Console.ReadLine();
            sw.Write(metin);
            sw.Close();
            Console.Read();
        }
    }
}
*/
namespace RandomVeMetinBelgesiİslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\Users\\user\\Desktop\\deneme2.txt", FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string metin=sr.ReadLine();
            while(metin != null)
            {
                Console.WriteLine(metin);
                metin = sr.ReadLine();
            }
            sr.Close();
            fs.Close();

            Console.Read();
        }
    }
}