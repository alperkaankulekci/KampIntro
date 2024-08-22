using System;
using System.Diagnostics;


namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKrediManager de string gibi bir veri tipidir artık.
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            //Bu kısmın banka personelinin ekranı olduğunu düşün
            BasvuruManager basvuruManager = new BasvuruManager();
            //Müşteri ihtiyaç kredisini seçti ve
            //ihtiyaç kredisi hesaplama fonksiyonu çalıştı. Çünkü onu yazdık.

            //2 tane loglayıcı tanımladık.
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

//Veri tabanına loglandı. fileLoggerService yazsaydım onu yazdırırdı.
//Yukarıda tanımladığımız için bir kodu değiştirmemiz yeterli olacaktır.
            basvuruManager.BasvuruYap(ıhtiyacKrediManager, databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager, tasitKrediManager } ;
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }

    }
}
