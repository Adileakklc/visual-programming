using System;
using System.Collections;

class UniqueCharacters
{
    static void Main()
    {
        while (true)
        {
            // Kullanıcıdan string girdi alınıyor
            Console.Write("Bir string giriniz (çıkış için 'x' giriniz): ");
            string input = Console.ReadLine();

            // Çıkış koşulu
            if (input.ToLower() == "x")
            {
                break;
            }

            // Karakterlerin tekrar edip etmediğini kontrol eden fonksiyon çağrılıyor
            var result = GetDuplicateCharacters(input);

            // Sonuç yazdırılıyor
            if (result.Count > 0)
            {
                Console.WriteLine("Tekrar eden karakterler:");
                foreach (char c in result)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("Hiçbir karakter tekrar etmiyor.");
            }
        }
    }

    static ArrayList GetDuplicateCharacters(string input)
    {
        // Hashtable oluşturuluyor
        Hashtable charTable = new Hashtable();
        ArrayList duplicateChars = new ArrayList();

        // String içerisindeki her karakter kontrol ediliyor
        foreach (char c in input)
        {
            // Eğer karakter zaten Hashtable içinde varsa, duplicateChars'e ekle
            if (charTable.ContainsKey(c))
            {
                if (!duplicateChars.Contains(c))
                {
                    duplicateChars.Add(c);
                }
            }
            else
            {
                // Karakteri Hashtable'a ekle
                charTable.Add(c, null);
            }
        }

        return duplicateChars;
    }
}
