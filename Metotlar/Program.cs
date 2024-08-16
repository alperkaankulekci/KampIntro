using Metotlar;

 class Program()
{
    //public kısmını ben ekledim
    public static void Main(string[] args)
    {
        string urunAdi = "elma";
        double fiyati = 15;
        string aciklama = "Amasya Elması";


        string[] meyveler = new string[] { "Elma", "Karpuz" };

        Urun urun1 = new Urun();
        urun1.Adi = "elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya Elması";

        Urun urun2 = new Urun();
        urun2.Adi = "karpuz";
        urun2.Fiyati = 80;
        urun2.Aciklama = "Diyarbakır karpuzu";

        Urun[] urunler = new Urun[] { urun1, urun2 };

        foreach (var urun in urunler)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("---------------------");
        }

        Console.WriteLine("-------METOTLAR-------");

        //örnek
        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);

        //Burada sepetManager ekle metodunu çağırır.
        //!Değişiklik olur ise (stok adedi eklendi diyelim) teker teker her yeri değiştirmek zorundayız.
        //O yüzden böyle durumlarda class kullanın
        sepetManager.Ekle2("Armut", "Yeşil armut", 12);
        sepetManager.Ekle2("Elma", "Yeşil elma", 12);
        sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12);

    }
}



