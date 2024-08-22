using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //İstediğimiz krediyi artık hesaplayabilir. Artık loglama işlemi de yapılabilir.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();
        }
        //Birden fazla bilgi var ise ve aynı türdelerse bu şekilde liste kullanabiliriz.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
        {
            //Tüm kredileri dolaş
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
