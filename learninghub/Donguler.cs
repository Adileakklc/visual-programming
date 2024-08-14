/*
namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Merhaba Dunyaa");
            }
            Console.Read();
        }
    }
}
*/
/*
namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i;
            //for (i = 1; i < 11; i++) {
            //Console.WriteLine(i);
            //}

            //int j;
            //for (j = 0; j <= 20; j+=2)
            //{
            //    Console.WriteLine(j);
            //}

            int k;
            for (k = 1; k <= 100; k+=1)
            {
                Console.WriteLine(k+"Merhaba İstanbul");
            }
            Console.Read();
        }
    }
}
*/
/*
namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 24 % 9;
            //Console.Write(sayi);

            //int sayi;
            //Console.Write("Sayıyı giriniz: ");
            //sayi = Convert.ToInt16(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");
            //}

            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
*/
/*
namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("sayıyı giriniz");
            sayi = Convert.ToInt16(Console.ReadLine());
            for (int i = 1;i <= sayi; i++)
            {
                if (sayi %i ==0)
                {
                    Console.WriteLine(i);
                };
            }
            Console.ReadLine();
        }
    }
}
*/
/*
namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakteri = 1;
            for (int i = 1; i <= 24; i++)
            {
                bakteri = bakteri * 2;
                Console.WriteLine(bakteri);
            }
            

            Console.ReadLine();
        }
    }
}
*/
/*
namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int toplam = 0;
            //for (int i = 1;i <= 10;i++) { 
            //toplam=toplam+i;
            //Console.WriteLine(toplam);}

            int faktoriyel = 1;
            for (int i = 5;i > 1;i--) 
            {
                faktoriyel = faktoriyel * i;
                Console.WriteLine(faktoriyel);
            }
            Console.Read();
        }
    }
}
*/
/*
namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayac = 1;
            //while (sayac < 10)
            //{
            //    Console.WriteLine("Hİ");
            //    sayac++;
            //}

            //int sayi = 1;
            //while(sayi<=20)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;

            //}
            int sayi = 1;
            int toplam = 0;
            while(sayi<=10)
            {
                toplam=toplam+sayi;
                sayi++;
            }
            Console.WriteLine(toplam);
            Console.Read();
        }
    }
}
*/
/*
namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int faktoriyel = 1;
            Console.WriteLine("Sayıyı Giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());
            while(sayi>=1)
            {
                faktoriyel = faktoriyel * sayi;
                sayi--;
            }
            Console.WriteLine("Sonuç: " + faktoriyel);
            Console.Read();
        }
    }
}
*/
/*
namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi;
            //sayi = 1;
            //while (sayi <= 10)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            int sayi = 1;
            do
            {
                Console.WriteLine(sayi);
                sayi++;
            }
            while (sayi <= 10);
            Console.Read();
        }
    }
}
*/



