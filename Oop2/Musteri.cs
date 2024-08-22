using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    //banka müsteri sistemi örneği
    class Musteri
    {
        //Excel gibi farklı programlara attığımızda sayılar farklı gözükür.
        //O yüzden toplama çıkarma gibi işlem yapmadığımız sürece string kaydedebiliriz.
        public int Id { get; set; }
        public string MusteriNo { get; set; }
    }
}
