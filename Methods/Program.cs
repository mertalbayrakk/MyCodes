
using Metotlar;


Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.Adi = "Çilek";
urun2.Fiyati = 10;
urun2.Aciklama = "Bebek gibi Çilek";

Urun[] uruns = new Urun[] { urun1, urun2 };

foreach (var yazdır in uruns)
{

    Console.WriteLine(yazdır.Adi);
    Console.WriteLine(yazdır.Fiyati);
    Console.WriteLine(yazdır.Aciklama);
    Console.WriteLine("---------------------");
}

Console.WriteLine("-----------Metotlar----------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);



sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
sepetManager.Ekle2("Çilek", "Miss çilek", 18, 5);
sepetManager.Ekle2("Turta", "Elmalı Turta", 56, 51);