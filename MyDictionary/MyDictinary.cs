using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictinary<MyKey,MyValue> // bu class mykey ve myvalue ile çalışan bir class.
    {
        (MyKey, MyValue)[] array;

        // * constructor ilk açtığımızda bir kez çalışır ve kapanır.
        // * ilk açtığımızda sıfır elemanı olması gerekli.
        public MyDictinary()
        {
            array = new (MyKey, MyValue)[0]; // * burada başlangıcı 0 olarak belirledik.
        }

        // * ekleme operasyonunu kendimiz yazıyoruz.
        // * mykey müşteri numaramızı tutuyor myvalue ise müşteri ismimizi.
        // * her müşteri eklendiğinde değerimizin 1 artması gerekiyor bunun için bir kod yazıyoruz.
        public void Add(MyKey customerNo,MyValue customerName)
        {
            // * geçici bir array oluşturduk ve arraya eşitledik.Çünkü her newlediğimiz de eski verimizi kaybedicez.
            (MyKey, MyValue)[] tempArray = array;
            // * yeni arrayimiz bi önceki arrayim hepsini alıcak ve onun üstüne +1 yeni eklediğimizi alıcak hepsi tutulacak.
            array = new (MyKey, MyValue)[array.Length + 1];
            // * bu tuttuğumuz değerleri dönmemiz gerekli.
            for (int i = 0; i < tempArray.Length; i++) // geçiçi arrayin uzunluğu kadar dönücek.
            {
                array[i] = tempArray[i]; 
            }
            array[array.Length - 1] = (customerNo, customerName);
        }
        // bir tane de kaç adet değer var sayma operasyonu yazıyorum.
        public int Count
        {
            get { return array.Length; }
        }

        // musterileri listelemek istersek şu şekilde yapabiliriz.
        public void Listeleme()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Müşteri Adı ve Müşteri Numarası: " + array[i]);
            }
        }
    }
}
