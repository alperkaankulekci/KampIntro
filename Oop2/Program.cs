using System;
using System.Diagnostics;


namespace Oop2
{

    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek müsteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "22222222222";

            //Tüzel müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //Bu şekilde - Chatgpt de müşteri yönetim sistemi başlığı altında detaylı bilgi var.
            //Staj defterine de oradan yaz.
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }

    }
}
