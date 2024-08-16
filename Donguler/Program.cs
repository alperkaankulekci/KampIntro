string kurs1 = "Yazılım geliştirme yetiştirici kampı";
string kurs2 = "Programlamaya giriş için temel kurs";


//array - dizi
string[] kurslar = new string[] { "Yazılım geliştirme yetiştirici kampı",
    "Programlamaya giriş için temel kurs" };

                        //kurslar kaç tane ise ona kadar devam etmesini sağlar.
for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("For döngüsünden çıkıldı");

//Bu kod kursları dolaş anlamını taşır. Sadece dizilerde çalışır.
//kurs yazan yere her şey yazılabilir. sadece takma addır.
//Yukarıdaki kod ile aynı işlevdedir.
//For daha genel kullanılırken dizileri gezmek için foreach kullanılır.
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
Console.WriteLine("foreach bitti");


Kurs Kurs1 = new Kurs();
Kurs1.KursAdi = "C#";
Kurs1.Egitmen = "Engin Demiroğ";
Kurs1.IzlenmeOrani = 68;

Kurs Kurs2 = new Kurs();
Kurs2.KursAdi = "Python";
Kurs2.Egitmen = "Kerem Varış";
Kurs2.IzlenmeOrani = 64;
class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}