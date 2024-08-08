using System;
using System.Collections.Generic;

class AnagramChecker
{
    static void Main()
    {
        while (true)
        {
            // Kullanıcıdan iki kelime alınıyor
            Console.Write("Birinci kelimeyi giriniz (çıkış için 'x' giriniz): ");
            string word1 = Console.ReadLine();
            // Çıkış koşulu
            if (word1.ToLower() == "x")
            {
                break;
            }
            Console.Write("İkinci kelimeyi giriniz: ");
            string word2 = Console.ReadLine();
            // Anagram olup olmadığını kontrol eden fonksiyon çağrılıyor
            bool isAnagram = AreAnagrams(word1, word2);
            // Sonuç yazdırılıyor
            if (isAnagram)
            {
                Console.WriteLine("Bu iki kelime anagramdır.");
            }
            else
            {
                Console.WriteLine("Bu iki kelime anagram değildir.");
            }
        }
    }

    static bool AreAnagrams(string word1, string word2)
    {
        // Boşlukları kaldırma ve küçük harfe dönüştürme
        word1 = RemoveNonLetters(word1.ToLower());
        word2 = RemoveNonLetters(word2.ToLower());
        // Eğer iki kelimenin uzunluğu farklı ise, anagram olamazlar
        if (word1.Length != word2.Length)
        {
            return false;
        }
        // Karakter sayıları için sözlük oluşturuluyor
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        // Birinci kelimenin karakter sayıları hesaplanıyor
        foreach (char c in word1)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }
        // İkinci kelimenin karakter sayıları kontrol ediliyor ve azaltılıyor
        foreach (char c in word2)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]--;
                if (charCount[c] < 0)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        return true;
    }
    // Harf olmayan karakterleri kaldıran yardımcı metot
    static string RemoveNonLetters(string input)
    {
        var result = new System.Text.StringBuilder();
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                result.Append(c);
            }
        }
        return result.ToString();
    }
}
