/*
namespace Degislenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //char degisken;
            //degisken = 'e';
            //Console.Write(degisken);

            //char deger;
            //deger = '7';
            //Console.Write(deger);

            char secim;
            Console.Write("Lütfen seçiminizi yapınız: ");
            secim = Convert.ToChar(Console.ReadLine());
            Console.Write("Seçiminiz: " + secim);


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
            //byte sayi1 = 25 , sayi2= 12 , toplam;
            //toplam = Convert.ToByte(sayi1 + sayi2);
            //Console.Write(toplam);

            byte s1, s2, toplam,carpim;
            Console.Write("1.sayı: ");
            s1 = Convert.ToByte(Console.ReadLine());
            Console.Write("2. sayi: ");
            s2 = Convert.ToByte(Console.ReadLine());
            carpim = Convert.ToByte(s1 * s2);
            Console.Write(carpim);

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
            //sbyte sayi;
            //sayi = 12;
            //Console.Write(sayi);

            //sbyte sayi2;
            //Console.Write("Sayıyı giriniz: ");
            //sayi2 = Convert.ToSByte(Console.ReadLine());
            //Console.Write(sayi2);

            sbyte s1, s2, toplam;
            Console.Write("Sayı1: ");
            s1 = Convert.ToSByte(Console.ReadLine());
            Console.Write("Sayı2: ");
            s2 = Convert.ToSByte(Console.ReadLine());
            toplam =Convert.ToSByte( s1 + s2);
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
            //float sayi;
            //sayi = 345f;
            //Console.Write(sayi);

            float s1, s2, toplam;
            Console.Write("Sayı 1: ");
            s1 = float.Parse(Console.ReadLine());
            Console.Write("Sayı 2: ");
            s2 = float.Parse(Console.ReadLine());
            toplam = s1 + s2;
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
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);

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
            //short s1,s2,toplam;
            //s1 = 45;
            //s2 = 1453;
            //toplam = (short)(s1 + s2);
            //Console.Write(toplam);

            short a, b, c;
            Console.Write("A: ");
            a = short.Parse(Console.ReadLine());
            Console.Write("B: ");
            b = short.Parse(Console.ReadLine());
            c = (short)(a * b);
            Console.Write(c);

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
            //ushort sayi,s1,s2;
            //s1 = 23;
            //s2 = 99;
            //sayi = (ushort)(s1 + s2);
            //Console.WriteLine(sayi);

            ushort a,b,c,d;
            Console.Write("Kısa kenarı giriniz: ");
            a = ushort.Parse(Console.ReadLine());
            Console.Write("Uzun kenarı giriniz: ");
            b = ushort.Parse(Console.ReadLine());
            c = (ushort)(a * b);
            Console.WriteLine(c);
            d = (ushort)(2 * a + 2 * b);
            Console.WriteLine(d);

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
            //decimal sayi1,sayi2,fark;
            //sayi1 = 20;
            //sayi2 = 12;
            //fark = sayi1 - sayi2;
            //Console.Write(fark);

            //decimal kenar, alan, cevre;
            //Console.Write("Kenarı giriniz: ");
            //kenar = Convert.ToDecimal(Console.ReadLine());
            //alan = kenar * kenar;
            //cevre = kenar * 4;
            //Console.Write("Çevre: "+ cevre +" Alan: "+alan);

            decimal sayi;
            sayi = 4.56m;
            Console.Write(sayi);


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
            //bool durum;
            //durum = true;
            //Console.Write("Öğrenci sınavı geçti mi: ");
            //Console.Write(durum);

            bool uyemi;
            Console.Write("Kullanıcı Sisteme üye mi(true ya da false diye cevap ver): ");
            uyemi = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Kullanıcının sistem üyelik durumu: " + uyemi);


            Console.Read();
        }
    }
}
*/