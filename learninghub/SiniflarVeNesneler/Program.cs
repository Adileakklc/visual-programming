/*
namespace SiniflarVeNesneler
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba.marka = "Marka bmw";
            araba.renk = "kırmızı";
            araba.motor = 1.23;
            araba.hiz = 155;
            araba.model = "2020";

            Console.Write("***ARABA TANITIM***");
            Console.WriteLine();
            Console.WriteLine("Marka: " + araba.marka);
            Console.WriteLine("Renk: " + araba.renk);
            Console.WriteLine("Motor: " + araba.motor);
            Console.WriteLine("Hız: " + araba.hiz);
            Console.WriteLine("Model: " + araba.model);
        }
    }
}
*/
/*
namespace SiniflarVeNesneler
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m = new Musteri();
            Console.Write("ID değerini giriniz: ");
            m.id= Convert.ToInt32(Console.ReadLine());
            Console.Write("Adınız: ");
            m.Ad=Console.ReadLine();
            Console.Write("Soyadınız: ");
            m.Soyad=Console.ReadLine();
            Console.Write("Şehriniz: ");
            m.sehir=Console.ReadLine();

            Console.WriteLine("Müşteri Kimlik Kartı");
            Console.WriteLine();
            Console.WriteLine(m.id+"-"+m.Ad+" "+m.Soyad+" "+m.sehir);

            Console.Read();
        }
    }
}
*/
/*
 Oluşturulan bir sınıf (class) içerisinde kullanıcının işlemlerini
daha kolay gerçekleştirebilmesi için bazı işlemler birleştirilerek tek bir işlem gibi gösterilir. 
Bu birleştirme işlemine kapsülleme denir.
*/
/*
 C# programlama dilinde kalıtım, bir sınıfın özelliklerinin başka bir sınıf 
tarafından miras alınmasıdır. Bu işlemle bir sınıfın sahip olduğu özellikleri,
başka bir sınıfın da kullanmasına olanak sağlar.
*/

namespace SiniflarVeNesneler
{
    class Program
    {
        static void Main(string[] args)
        {
            papagan p = new papagan();
            p.tur = "Papağan";
            p.hiz = 45;
            p.isim = "Aşk Kuşu";
            p.renk = "Sarı-Kırmızı";
            //p.ses = "Cik";
            p.agirlik = 41;
            p.sescikar();

            Console.WriteLine("Tür: " + p.tur);
            Console.WriteLine("İsim: " + p.isim);
            Console.WriteLine("Hız: " + p.hiz);
            Console.WriteLine("Ağırlık: " + p.agirlik);
            //Console.WriteLine("Ses: " + p.ses);
            Console.WriteLine("Renk: " + p.renk);
            Console.WriteLine("Ses: "+p.sescikar());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("************");
            Console.WriteLine();
            karga k = new karga();
            k.tur = "Karga";
            k.hiz = 53;
            k.isim = "Leş Kargası";
            k.renk = "Siyah";
            k.agirlik = 520;
            k.sescikar();

            Console.WriteLine("Tür: " + k.tur);
            Console.WriteLine("İsim: " + k.isim);
            Console.WriteLine("Hız: " + k.hiz);
            Console.WriteLine("Ağırlık: " + k.agirlik);
            Console.WriteLine("Renk: " + k.renk);
            Console.WriteLine("Ses: " + k.sescikar());

            Console.Read();
        }
    }
}

/*
 C#'ta çok biçimlilik(polymorphism), programımızda oluşan bir nesne
yapısının birbirinden farklı nesneler şeklinde davranmasına sağlayan 
yapıdır 
*/

