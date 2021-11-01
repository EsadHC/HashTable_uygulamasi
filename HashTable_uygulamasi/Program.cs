using System;
using System.Collections;

namespace HashTable_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //HASHTABLE uygulaması
            Console.WriteLine("Başlık giriniz: ");
            string Baslik = Console.ReadLine();

            //küçültme işlemi
            Baslik = Baslik.ToLower();
            //Hastable 
            var karakter_seti = new Hashtable()
            {
                {'ç','c' },
                {'ı','i' },
                {'ö','o' },
                {'ü','u' },
                {' ','-' },
                {'ğ','g' },
                {'\'','-' },
            };

            foreach (DictionaryEntry item in karakter_seti)
            {
                Baslik = Baslik.Replace((char)item.Key,(char)item.Value);
            }

            //yeni balığı ekrana yazdırma
            Console.WriteLine(Baslik);

            Console.ReadKey();
        }
    }
}
