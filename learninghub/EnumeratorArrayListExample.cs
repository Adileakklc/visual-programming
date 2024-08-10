using System;
using System.Collections;

namespace BM
{
    class App
    {
        public static void Main()
        {
            // ArrayList oluşturuluyor
            ArrayList numbers = new ArrayList();

            // ArrayList'e elemanlar ekleniyor (0, 10, 20, ..., 90)
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i * 10);
            }

            // IEnumerator ile ArrayList'teki elemanlar üzerinde geziniyoruz
            IEnumerator enumerator = numbers.GetEnumerator();

            Console.WriteLine("ArrayList içeriği:");

            // MoveNext() ile bir sonraki elemana geçiyoruz, Current ile mevcut elemanı alıyoruz
            while (enumerator.MoveNext())
            {
                int currentNumber = (int)enumerator.Current; // Tip dönüşümü yapılıyor
                Console.Write(currentNumber + " "); // Eleman ekrana yazdırılıyor
            }

            Console.WriteLine(); // Boş bir satır eklemek için

            // Yineleyiciyi başa döndürüyoruz
            enumerator.Reset(); // Enumerator başa döndürülüyor

            // ArrayList'e yeni elemanlar ekleyelim
            numbers.Add(100);
            numbers.Add(110);

            // Yeni elemanlar eklendiği için IEnumerator'u tekrar oluşturuyoruz
            enumerator = numbers.GetEnumerator();

            Console.WriteLine("ArrayList içeriği (Yeni elemanlar eklendikten sonra):");

            // Yine elemanları yazdırıyoruz
            while (enumerator.MoveNext())
            {
                int currentNumber = (int)enumerator.Current;
                Console.Write(currentNumber + " ");
            }

            Console.WriteLine(); // Boş bir satır eklemek için
        }
    }
}
