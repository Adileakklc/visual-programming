using System;
using System.Collections;

class sehirlerin_ilceleri
{
    static void Main()
    {
        // Hashtable nesnesi olusturuluyor
        Hashtable cities = new Hashtable();

        // Sehir ve ilceler ekleniyor
        cities.Add("Elazig", new string[] { "Palu", "Maden", "Keban", "Sivrice" });
        cities.Add("Bursa", new string[] { "Nilüfer", "Yildirim", "Karacabey", "Orhaneli" });
        cities.Add("Ankara", new string[] { "Etimesgut", "Mamak", "Beypazari", "Cankaya" });
        cities.Add("Sivas", new string[] { "Gurun", "Kangal", "Zara", "Ulas" });
        cities.Add("Diyarbakir", new string[] { "Cungus", "Sur", "Ergani", "Cermik" });


        while (true)
        {
            // Kullanicidan sehir ismi isteniyor
            Console.Write("Şehir ismi giriniz (çıkış için 'x' giriniz): ");
            string city = Console.ReadLine();

            // Çıkış koşulu
            if (city.ToLower() == "x")
            {
                break;
            }

            // Girilen şehir sözlükte var mı kontrol ediliyor
            if (cities.ContainsKey(city))
            {
                // İlçeler alınıyor ve yazdırılıyor
                string[] districts = (string[])cities[city];
                Console.WriteLine($"{city} şehrinin ilçeleri:");
                foreach (string district in districts)
                {
                    Console.WriteLine($"- {district}");
                }
            }
            else
            {
                // Şehir bulunamazsa hata mesajı
                Console.WriteLine($"{city} isimli şehir bulunamadı.");
            }
        }
    }
}
