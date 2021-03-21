using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // normal dictionary kullanmı bu şekilde

            Console.WriteLine("-*-*-*-*-*-*-*-*-*Normal Dictionary Başlangıç-*-*-*-*-*-*-*");

            Dictionary<string, int> musteriler = new Dictionary<string, int>();
            musteriler.Add("Azra" ,1234); // ekleme operasyonu kendinden vardır.
            Console.WriteLine("Müşteri Sayısı : " +musteriler.Count); // kaç elamanı var saymak istersek yine kendinden var

            Console.WriteLine("-*-*-*-*-*-*-*-*--* Normal Dictionary Sonu-*-*-*-*-*-*-*-*-*-* ");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("-*-*-*-*-*-*-*-*--* Kendi Dictionary Başlangıcımız-*-*-*-*-*-*-*-*-*-* ");


            // biz kendi dictionary mizi yazacağız.
            MyDictinary<string,int> musteriler2 = new MyDictinary<string,int>();
            musteriler2.Add("Batuhan" , 4567);
            musteriler2.Add("İbrahim", 1234);
            musteriler2.Add("Halil", 9876);
            Console.WriteLine("Müşteri sayısı : " + musteriler2.Count);
            musteriler2.Listeleme();

            Console.WriteLine("-*-*-*-*-*-*-*-*--* Kendi Dictionary Sonu-*-*-*-*-*-*-*-*-*-* ");

        }
    }
}
