/*
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "adana", "bursa", "elazığ", "malatya" };
            //Console.WriteLine("Dizimizin 2.Index Değeri: " + sehirler[2]);
            Console.WriteLine(sehirler[0]);
            Console.WriteLine(sehirler[1]);
            Console.WriteLine(sehirler[2]);
            Console.WriteLine(sehirler[3]);
            Console.Read();
        }
    }
}
*/
/*
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Int degiskenler ile dizi kullanımları");
            Console.WriteLine();
            int [] sayilar= {10,20,30,40,50,60,70};
            //Console.WriteLine(sayilar[4]);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.Read();
        }
    }
}
*/
/*
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar= {10,20,30,40,50,60,70,80,90};
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]%20 == 0&& sayilar[i] % 30 == 0)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }
            Console.Read();
        }
    }
}
*/
/*
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length Kullanımı");

            string[] kisiler = { "ali", "mehmet", "aslı", "elif", "ahmet" };
            for(int i = 0; i < kisiler.Length; i++)
            {
                Console.WriteLine(kisiler[i]);
            }
        }
     }

}
*/
/*
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizilerde toplama işlemi örneği");
            Console.WriteLine();
            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine(toplam);
            Console.Read();
        }
    }
}
*/
/*
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 15, 23, 13, 41, 15, 6, 87, 18, 9 };
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.Read();
        }
    }
}
*/
/*
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Adana", "Ankara", "Bursa", "Elazığ" };
            //Array.Reverse(sehirler);
            Array.Sort(sehirler);
            Array.Reverse(sehirler);
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            Console.ReadLine();
        }
    }
}
*/
/*
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kisiler = { "Adile", "Gamze", "İrem", "Beyza","Nisa" };
            int sira;
            Array.Sort(kisiler);
            sira = Array.IndexOf(kisiler, "Beyza");
            Console.WriteLine(sira);

            Console.ReadLine();
        }
    }
}
*/
/*
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 14, 52, 98, 30, 41, 65 };
            Console.WriteLine(sayilar.Min());
            Console.WriteLine(sayilar.Max());

            Console.ReadLine();
        }
    }
}
*/
/*
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Van", "Muş", "İzmir" };
            foreach (string s in sehirler)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
*/
/*
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //int toplam = 0;
            //foreach (int i in sayilar)
            //{
            //    toplam=toplam+i;
            //}
            //Console.WriteLine("Toplam: "+toplam);
            int[] sayilar = { 1, 2, 3 };
            foreach (int i in sayilar)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
*/
/*
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Şehir ismi: ");
                sehirler[i] = Console.ReadLine();
            }
            for (int j = 0;j < 5;j++)
            {
                Console.WriteLine(sehirler[j]);
            }
            Console.Read();
        }
    }
}
*/