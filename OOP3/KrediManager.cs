using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Sistem aynı değerleri farklı ise interface kullanılır.
    //Mesela kredide faiz dosya masrafı vs hep var ama bu değerler farklıdır.
    //Hesaplaması da aynıdır. O yüzden interface içinde yazabilirim.
    interface IKrediManager
//I ile başlarsa interface olduğunu daha rahat anlayabiliriz. Bu kod okunurluğunu anlatmak içindir.
    {
        void Hesapla();
        void BiseyYap();
        

        
    }
}
