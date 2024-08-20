using System;
using System.Diagnostics;
using System.Collections.Generic;


namespace Koleksiyonlar
{

    class Program
    {
        static void Main(string[] args)
        {
            //seçip ctrl k + ctrl c yapar isek yorum satırı yapar.
            //seçip ctrl k + ctrl u yapar isek de yorum satırını siler.

            //Diziler tanımlanan sınırlar içinde kalır.
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            ////0. indeksini yazdır. 
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //Bu şekilde tanımlama yapabiliriz ama bunu yaptığımızda 5 indeksli yeni 
            //bir array oluşturulur. Önceki tanımlamalarımız gidecektir.
            //Bu yüzden array çok kullanılmaz.

            //Listelerde ise sonradan aşağıdaki gibi ekleme yapılabilir.
            List<String> isimler2 = new List<String> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine("Yeni elemanımız eklenmiş: " + isimler2[4]);

        }

    }
}
