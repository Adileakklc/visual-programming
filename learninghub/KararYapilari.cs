/*
 * namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            string sehir;
            Console.Write("Şehir ad: ");
            sehir = Console.ReadLine();
            if(sehir=="adana")
            {
                Console.WriteLine("doğru şehir");
            }
            else
            {
                Console.Write("yanlış şehir");
            }
            Console.Read();
        }
    }
}
*/
/*
namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi;
            //Console.Write("Sayiyi giriniz: ");
            //sayi = Convert.ToInt16(Console.ReadLine());

            //if(sayi==23)
            //{
            //    Console.WriteLine("sayı doğru girildi");

            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış girildi");
            //}
            int s1, s2, ort;
            Console.Write("Sınav1: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sınav2: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            ort = (s1 + s2) / 2;
            Console.Write("Ortalamanız: " + ort);

            if (ort>=50)
            {
                Console.Write("-----Geçtiniz");
            }
            else
            {
                Console.Write("-----Kaldınız");
            }
            Console.Read();
        }
    }
}
*/
/*
namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            string Kullanici, sifre;
            Console.Write("Kullanici adiniz: ");
            Kullanici = Console.ReadLine();
            Console.Write("Şifenizi giriniz: ");
            sifre = Console.ReadLine();

            if(Kullanici=="admin"&&sifre=="123456")
            {
                Console.Write("hoşgeldinizz");
            }
            else
            {
                Console.Write("hata");
            }
            Console.Read();
        }
    }
}
*/
/*
namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, ort;
            Console.Write("Sınav1: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sınav2: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sınav3: ");
            s3 = Convert.ToInt16(Console.ReadLine());

            ort = (s1 + s2 + s3)/3;
            Console.Write("Ortalamanız: " + ort);

            if(ort<50)
            {
                Console.WriteLine("  Durum: Vasat");
            }
            if(ort>=50&&ort<=65)
            {
                Console.WriteLine("  Durum: Orta");
            }
            if(ort>65&&ort<=79)
            {
                Console.WriteLine("   Durum: İyi");
            }
            if(ort>79)
            {
                Console.Write(" Durum : Çok İyi");
            }

            Console.Read();
        }
    }
}
*/
/*
namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            char karakter;
            Console.Write("Karakteri giriniz: ");
            karakter = Convert.ToChar(Console.ReadLine());

            if(karakter != 'a')
            {
                Console.Write("a harfi girmediniz tebriklerr");
            }
            else
            {
                Console.Write("hata çünkü a harfi girdiniz");
            }
            Console.Read();
        }
    }
}
*/
/*
using System.ComponentModel.Design;

namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***C# YARIŞMASINA HOŞGELDİN ***");
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            int soru = 1;
            string cevap;
            if(soru==1)
            {
                Console.WriteLine("IList arayüzü hangi koleksiyonlar için kullanılır?");
                Console.WriteLine();
                Console.WriteLine("A) Anahtar-değer çiftleri saklayan koleksiyonlar");
                Console.WriteLine("B) Liste tabanlı koleksiyonlar");
                Console.WriteLine("C) Stream tabanlı koleksiyonlar");
                Console.WriteLine("D) Queue tabanlı koleksiyonlar");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "b" || cevap == "B") 
                {
                    soru=soru+1;
                }
                else
                {
                    Console.Write("Cevap yanlış! Toplam puanınız : 0");
                }
            }
            if(soru==2)
            {
                Console.WriteLine("Add() metodu SortedList sınıfında ne yapar");
                Console.WriteLine();
                Console.WriteLine("A) Elemanı koleksiyonun sonuna ekler");
                Console.WriteLine("B) Elemanı belirtilen indekse ekler");
                Console.WriteLine("C) Elemanı sıralı bir şekilde koleksiyona ekler");
                Console.WriteLine("D) Elemanı siler");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "c" || cevap == "C")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış! Toplam puanınız : 10");
                }
            }
            if (soru == 3)
            {
                Console.WriteLine("IndexOf() metodu aşağıdaki işlemlerden hangisini gerçekleştirir?");
                Console.WriteLine();
                Console.WriteLine("A) Elemanı siler");
                Console.WriteLine("B) Elemanı indeksini döner");
                Console.WriteLine("C) Elemanı ekler");
                Console.WriteLine("D) Elemanı günceller");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "b" || cevap == "B")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış! Toplam puanınız : 20");
                }
            }
            if (soru == 4)
            {
                Console.WriteLine("Aşağıdaki metotlardan hangisi ArrayList sınıfındaki tüm elemanları siler?");
                Console.WriteLine();
                Console.WriteLine("A) Remove()");
                Console.WriteLine("B) RemoveAt()");
                Console.WriteLine("C) Clear()");
                Console.WriteLine("D) CopyTo");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "c" || cevap == "C")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış! Toplam puanınız : 30");
                }
            }
            if (soru == 5)
            {
                Console.WriteLine("ICollection arayüzünün SyncRoot özelliği neyi belirler?");
                Console.WriteLine();
                Console.WriteLine("A) Koleksiyonun boyutunu");
                Console.WriteLine("B) Koleksiyonun thread güvenli olup olmadığını");
                Console.WriteLine("C) Koleksiyonun senkronizasyonu için kullanılan nesneyi");
                Console.WriteLine("D) Koleksiyondaki öğelerin sayısını");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "c" || cevap == "C")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış! Toplam puanınız : 40");
                }
            }
            if (soru == 6)
            {
                Console.WriteLine("Hashtable sınıfının generic versiyonu aşağıdakilerden hangisidir?");
                Console.WriteLine();
                Console.WriteLine("A) List<T>");
                Console.WriteLine("B) Dictionary<TKey, TValue>");
                Console.WriteLine("C) ArrayList");
                Console.WriteLine("D) SortedList");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "b" || cevap == "B")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış! Toplam puanınız : 50");
                }
            }
            if (soru == 7)
            {
                Console.WriteLine("IEnumerator arayüzü aşağıdaki özelliklerden hangisine sahiptir?");
                Console.WriteLine();
                Console.WriteLine("A) IsSynchronized");
                Console.WriteLine("B) Add()");
                Console.WriteLine("C) Count");
                Console.WriteLine("D) MoveNext()");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "d" || cevap == "D")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış! Toplam puanınız : 60");
                }
            }
            if (soru == 8)
            {
                Console.WriteLine("IndexOf() metodu aşağıdaki işlemlerden hangisini gerçekleştirir?");
                Console.WriteLine();
                Console.WriteLine("A) Insert()");
                Console.WriteLine("B) Add()");
                Console.WriteLine("C) Remove()");
                Console.WriteLine("D) Clear()");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "a" || cevap == "A")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış! Toplam puanınız : 70");
                }
            }
            if (soru == 9)
            {
                Console.WriteLine("IEnumerable arayüzü hangi metodu tanımlar?");
                Console.WriteLine();
                Console.WriteLine("A) MoveNext()");
                Console.WriteLine("B) GetEnumerator()");
                Console.WriteLine("C) Reset()");
                Console.WriteLine("D) Current");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "b" || cevap == "B")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış! Toplam puanınız : 80");
                }
            }
            if (soru == 10)
            {
                Console.WriteLine("Aşağıdaki sınıflardan hangisi IEnumerable arayüzünü implemente etmez?");
                Console.WriteLine();
                Console.WriteLine("A) Stream");
                Console.WriteLine("B) ArrayList");
                Console.WriteLine("C) List<T>");
                Console.WriteLine("D) Hashtable");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "a" || cevap == "A")
                {
                    Console.Write("Tebrikler tüm soruları bildiniz puanınız : 100");
                }
                else
                {
                    Console.Write("Cevap yanlış! Toplam puanınız : 90");
                }
            }
            Console.Read();
        }
    }
}
*/
/*
namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            byte plaka;
            Console.Write("Lütfen plakayı giriniz: ");
            plaka = byte.Parse(Console.ReadLine());

            switch (plaka)
            {
                case 1: Console.Write("Merhaba Adana"); break;
                case 2: Console.Write("Merhaba Adıyaman"); break;
                case 3: Console.Write("Merhaba Afyon"); break;
                case 4: Console.Write("Merhaba Ağrı"); break;
                case 5: Console.Write("Merhaba Amasya"); break;
                case 6: Console.Write("Merhaba Ankara"); break;
                case 7: Console.Write("Merhaba Antalya"); break;
                case 8: Console.Write("Merhaba Artvin"); break;
                case 9: Console.Write("Merhaba Aydın"); break;
                case 10: Console.Write("Merhaba Balıkesir"); break;
                case 11: Console.Write("Merhaba Bilecik"); break;
                case 12: Console.Write("Merhaba Bingöl"); break;
                case 13: Console.Write("Merhaba Bitlis"); break;
                case 14: Console.Write("Merhaba Bolu"); break;
                case 15: Console.Write("Merhaba Burdur"); break;
                case 16: Console.Write("Merhaba Bursa"); break;
                case 17: Console.Write("Merhaba Çanakkale"); break;
                case 18: Console.Write("Merhaba Çankırı"); break;
                case 19: Console.Write("Merhaba Çorum"); break;
                case 20: Console.Write("Merhaba Denizli"); break;
                case 21: Console.Write("Merhaba Diyarbakır"); break;
                case 22: Console.Write("Merhaba Edirne"); break;
                case 23: Console.Write("Merhaba Elazığ"); break;
                case 24: Console.Write("Merhaba Erzincan"); break;
                case 25: Console.Write("Merhaba Erzurum"); break;
                case 26: Console.Write("Merhaba Eskişehir"); break;
                case 27: Console.Write("Merhaba Gaziantep"); break;
                case 28: Console.Write("Merhaba Giresun"); break;
                case 29: Console.Write("Merhaba Gümüşhane"); break;
                case 30: Console.Write("Merhaba Hakkari"); break;
                case 31: Console.Write("Merhaba Hatay"); break;
                case 32: Console.Write("Merhaba Isparta"); break;
                case 33: Console.Write("Merhaba Mersin"); break;
                case 34: Console.Write("Merhaba İstanbul"); break;
                case 35: Console.Write("Merhaba İzmir"); break;
                case 36: Console.Write("Merhaba Kars"); break;
                case 37: Console.Write("Merhaba Kastamonu"); break;
                case 38: Console.Write("Merhaba Kayseri"); break;
                case 39: Console.Write("Merhaba Kırklareli"); break;
                case 40: Console.Write("Merhaba Kırşehir"); break;
                case 41: Console.Write("Merhaba Kocaeli"); break;
                case 42: Console.Write("Merhaba Konya"); break;
                case 43: Console.Write("Merhaba Kütahya"); break;
                case 44: Console.Write("Merhaba Malatya"); break;
                case 45: Console.Write("Merhaba Manisa"); break;
                case 46: Console.Write("Merhaba Kahramanmaraş"); break;
                case 47: Console.Write("Merhaba Mardin"); break;
                case 48: Console.Write("Merhaba Muğla"); break;
                case 49: Console.Write("Merhaba Muş"); break;
                case 50: Console.Write("Merhaba Nevşehir"); break;
                case 51: Console.Write("Merhaba Niğde"); break;
                case 52: Console.Write("Merhaba Ordu"); break;
                case 53: Console.Write("Merhaba Rize"); break;
                case 54: Console.Write("Merhaba Sakarya"); break;
                case 55: Console.Write("Merhaba Samsun"); break;
                case 56: Console.Write("Merhaba Siirt"); break;
                case 57: Console.Write("Merhaba Sinop"); break;
                case 58: Console.Write("Merhaba Sivas"); break;
                case 59: Console.Write("Merhaba Tekirdağ"); break;
                case 60: Console.Write("Merhaba Tokat"); break;
                case 61: Console.Write("Merhaba Trabzon"); break;
                case 62: Console.Write("Merhaba Tunceli"); break;
                case 63: Console.Write("Merhaba Şanlıurfa"); break;
                case 64: Console.Write("Merhaba Uşak"); break;
                case 65: Console.Write("Merhaba Van"); break;
                case 66: Console.Write("Merhaba Yozgat"); break;
                case 67: Console.Write("Merhaba Zonguldak"); break;
                case 68: Console.Write("Merhaba Aksaray"); break;
                case 69: Console.Write("Merhaba Bayburt"); break;
                case 70: Console.Write("Merhaba Karaman"); break;
                case 71: Console.Write("Merhaba Kırıkkale"); break;
                case 72: Console.Write("Merhaba Batman"); break;
                case 73: Console.Write("Merhaba Şırnak"); break;
                case 74: Console.Write("Merhaba Bartın"); break;
                case 75: Console.Write("Merhaba Ardahan"); break;
                case 76: Console.Write("Merhaba Iğdır"); break;
                case 77: Console.Write("Merhaba Yalova"); break;
                case 78: Console.Write("Merhaba Karabük"); break;
                case 79: Console.Write("Merhaba Kilis"); break;
                case 80: Console.Write("Merhaba Osmaniye"); break;
                case 81: Console.Write("Merhaba Düzce"); break;

                default: Console.Write("Şehir bulunamadı"); break;
            }
        }
    }
}
*/
/*
namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Değişkenleri ile Switch Case Mevsim Uygulaması");
            Console.WriteLine();
            string mevsim;
            Console.Write("Lütfen mevsimi giriniz: ");
            mevsim = Console.ReadLine();
            switch (mevsim)
            {
                case "yaz": Console.WriteLine("Haziran-Temmuz-Ağustos"); break;
                case "ilkbahar": Console.WriteLine("Mart-Nisan-Mayıs"); break;
                case "sonbahar": Console.WriteLine("Eylül-Ekim-Kasım"); break;
                case "kış": Console.WriteLine("Aralık-Ocak-Şubat"); break;
                default: Console.WriteLine("hatalı mevsim girişi"); break;

            }
            Console.Read();
        }
    }
}
*/


