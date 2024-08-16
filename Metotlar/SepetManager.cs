using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //metot(fonksiyon) yazmak      
        public void Ekle(Urun urun) //Bu şekilde urun yazmalıyız ki ne eklediğimizi bilelim.
        {
            Console.WriteLine("Sepete eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat) 
        {
            Console.WriteLine("Sepete eklendi: " + urunAdi);

        }
    }
}
