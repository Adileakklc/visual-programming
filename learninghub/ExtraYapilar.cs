/*
namespace ExtraYapılar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Adile Nasilsin");
            Console.Read();
        }
    }
}
*/
/*
namespace ExtraYapılar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matrisler
            int[,] sayilar = new int[2, 2];
            sayilar[0, 0] = 16;
            sayilar[0, 1] = 23;
            sayilar[1, 0] = 35;
            sayilar[1, 1] = 42;
            Console.WriteLine(sayilar[0,0]);
            Console.ReadLine();
        }
    }
}
*/
/*
namespace ExtraYapılar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yıldızla
            //Console.WriteLine("*******");
            
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("********");
            //}
            for (int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
*/
/*
namespace ExtraYapılar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yıldızlarla dik üçgen oluşturma
            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
*/

namespace ExtraYapılar
{
    class Program
    {
        static void Main(string[] args)
        {
            //HataYönetimi
            try
            {
                int s1, s2, sonuc;
                Console.Write("Sayı 1: ");
                s1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("Sayı 2: ");
                s2 = Convert.ToInt16(Console.ReadLine());
                sonuc = s1 * s2;
                Console.WriteLine("İşlem  Sonucu: " + sonuc);
            }
            //catch (Exception ex)
            //catch (FormatException)
            //{
            //    //Console.WriteLine("Hata var lütfen formatınızı kontrol ediniz");
            //    //Console.Write(ex);
            //    Console.WriteLine("Lütfen sadece sayısal değerler gir");
            //}
            //catch(OverflowException)
            //{
            //    Console.WriteLine("Lütfen aralığın dışında değer girmeyin");
            //}
            catch (Exception)
            {
                Console.WriteLine("Hata");
            }
            finally { Console.WriteLine("Burası Çalıştı"); }

            Console.Read();
        }
    }
}

/*
 -InvalidCastException sınıfının yeni bir örneğini serileştirilmiş verilerle başlatır. 
Belirtilen hata iletisiyle sınıfının yeni bir örneğini InvalidCastException başlatır. 
Belirtilen bir hata iletisi ve bu özel durumun nedeni olan iç özel duruma başvuruyla 
sınıfının yeni bir örneğini InvalidCastException başlatır.

 -IndexOutOfRangeException dizinin veya koleksiyonun üyesine erişmek ya da arabellekteki 
belirli bir konumdan okumak veya yazmak için geçersiz bir dizin kullanıldığında 
özel durum oluşturulur. Bu özel durum sınıfından devralınır Exception ancak benzersiz üye eklemez.

 -DivideByZeroException sınıfının yeni bir örneğini serileştirilmiş verilerle başlatır. 
Belirtilen hata iletisiyle sınıfının yeni bir örneğini DivideByZeroException başlatır. 
Sınıfın DivideByZeroException yeni bir örneğini belirtilen bir hata iletisiyle ve bu özel durumun
nedeni olan iç özel duruma başvuruyla başlatır.

 -format exception : Bağımsız değişkenin biçimi geçersiz olduğunda veya bileşik 
biçim dizesi iyi biçimlendirilmediğinde oluşturulan özel durum.

 -overflow exception : Türetilmiş bir sınıfta geçersiz kılındığında, sonraki bir veya daha fazla 
özel durumun kök nedeni olan Exception döndürür. Varsayılan karma işlevi işlevi görür. 
*/



