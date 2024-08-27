/*
 * public:herkese acik
 * private: gizli
 * internal: kullanılan kod bloğu içinde erişim var
 * protected: tanımlı ve miras alan sınıflardan erişim var
 */
// erişim_belirleyici_türü(public,private,internal,protected) static metot_türü metot_adı()
/*
namespace metotlar
{
    class Program
    {
        public static void yazdir() 
        {
            Console.Write("Bu bir metottur");
            Console.WriteLine();
            Console.Write("Merhabaa");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            yazdir();
            Console.WriteLine("*************");
            Console.WriteLine();
            yazdir();
            Console.Read();
        }
    }
}
*/
/*
namespace metotlar
{
    class Program
    {
        public static int ortalama(int s1, int s2)
        {
            int sonuc = (s1 + s2)/2;
            return sonuc;   
        }
        public static int ortalama(int s1, int s2, int s3)
        {
            int sonuc = (s1 + s2+ s3) / 3;
            return sonuc;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Ortalama: "+ortalama(71, 29));
            Console.WriteLine(ortalama(1, 3, 5));//overload
            Console.Read();
        }
    }
}
*/
/*
namespace metotlar
{
    class Program
    {
        private static int Hesapla(int kisa, int uzun)
        {
            int alan = kisa * uzun;
            return alan;
        }

        static void Main(string[] args)
        {
            Console.Write("Kısa kenarı girin :");
            int kisa_kenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun kenarı girin :");
            int uzun_kenar = Convert.ToInt32(Console.ReadLine());
            int sonuc = Hesapla(kisa_kenar, uzun_kenar);
            Console.WriteLine("Alan = " + sonuc);
            Console.ReadKey();
        }
    }

}
*/
/*
namespace metotlar
{
    class Program
    {
        private static bool Tek(int sayi)
        {
            bool teksayi = true;
            bool ciftsayi = false;
            if (sayi %2 ==1) 
                return teksayi;
            else return ciftsayi;
        }
            
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int s=int.Parse(Console.ReadLine());
            Console.WriteLine(Tek(s));
            Console.ReadLine();
        }
    }
}
*/
/*
namespace metotlar
{
    class Program
    {
        private static int formul(int A, int B)
        {
            int SONUC;
            SONUC = (A * A) + (B * B);
            return SONUC;
        }

        static void Main(string[] args)
        {

            Console.Write("A'yı giriniz: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B'yı giriniz: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(formul(a, b));
            Console.ReadKey();
        }
    }
}
*/
