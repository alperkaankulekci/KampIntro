using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{

            //T olan yere her şey yazılabilir. Type kısaltması olarak T yazdık.
    class MyList<T>
    {
        T[] items;

        //constructor
        //bu kısım otomatik ve en başta çalışır.
        public MyList()
        {
            items = new T[0];
        }

        //T[] array kısmına eklemeleri buradan yapacağız
        public void Add(T item) 
        {
            //tempArray = Geçici dizi
            T[] tempArray = items;
            //Bu kod sayesinde items dosyaları tempArray kısmına kaydedilir.
            //Çünkü aşağıdaki kod verileri silip 1 arttırır. O verileri de bu şekilde kurtaracağız.

            //Dizinin uzunluğunu bulur ve 1 arttırır.
            items = new T[items.Length+1];

            //tempArray den verileri items a tekrar vereceğiz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            //-1 yazma sebebimiz index sayısını bulmak istediğimiz içindir.
            //Length bize eleman sayısını verir. Bize index gerekiyor. 0dan
            items[items.Length -1] = item;
        }
    }
}
