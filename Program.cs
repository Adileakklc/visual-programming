using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class DirectoryList : IEnumerable
{
    private string[] m_files;

    // Constructor: Belirtilen dizindeki dosya isimlerini alır
    public DirectoryList(string dir)
    {
        // Dizindeki dosya isimlerini al ve m_files dizisine yerleştir
        if (Directory.Exists(dir))
        {
            m_files = Directory.GetFiles(dir);
        }
        else
        {
            throw new DirectoryNotFoundException($"The directory '{dir}' does not exist.");
        }
    }

    // IEnumerable arayüzünün GetEnumerator fonksiyonu
    public IEnumerator GetEnumerator()
    {
        return new DirectoryListEnumerator(this);
    }

    // İç sınıf: IEnumerator arayüzünü destekler
    private class DirectoryListEnumerator : IEnumerator
    {
        private DirectoryList m_dl;
        private int m_index;

        // Constructor: Dış sınıfın referansını al ve indeksin başlangıç değerini ayarla
        public DirectoryListEnumerator(DirectoryList dl)
        {
            m_dl = dl;
            m_index = -1; // İlk başta -1 olarak başlar, böylece MoveNext() ilk çağrıldığında 0'a çıkar
        }

        // IEnumerator.Current: Şu anki öğeyi döndürür
        public object Current
        {
            get
            {
                if (m_index >= 0 && m_index < m_dl.m_files.Length)
                {
                    return m_dl.m_files[m_index];
                }
                throw new InvalidOperationException();
            }
        }

        // IEnumerator.MoveNext: İndeksi bir sonraki öğeye taşır
        public bool MoveNext()
        {
            if (m_index < m_dl.m_files.Length - 1)
            {
                m_index++;
                return true;
            }
            return false;
        }

        // IEnumerator.Reset: İndeksi başa alır
        public void Reset()
        {
            m_index = -1;
        }
    }
}

class Program
{
    public static void Main()
    {
        // Test kodu
        try
        {
            DirectoryList dl = new DirectoryList("C:\\windows");
            foreach (string s in dl)
            {
                Console.WriteLine(s);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
