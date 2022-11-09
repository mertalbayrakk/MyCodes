Urunler Urun1 = new Urunler();
Urun1.UrununAdi = "İPhone 13";
Urun1.UrununFiyati = 25000;
Urun1.UrununYildizi = 4.8;
Urun1.IndirimOrani = 15;

Urunler Urun2 = new Urunler();
Urun2.UrununAdi = "Şarj Aleti";
Urun2.UrununFiyati = 145;
Urun2.UrununYildizi = 3.8;
Urun2.IndirimOrani = 25;


Urunler Urun3 = new Urunler();
Urun3.UrununAdi = "Monster Notebook";
Urun3.UrununFiyati = 16000;
Urun3.UrununYildizi = 4.9;
Urun3.IndirimOrani = 20;


Urunler[] UrunListesi = new Urunler[] { Urun1, Urun2, Urun3 };

Console.WriteLine("----------For Döngüsü----------");

for (int i = 0; i < UrunListesi.Length; i++)
{
    Console.WriteLine(UrunListesi[i].UrununAdi + " " + UrunListesi[i].UrununFiyati + "TL  " + UrunListesi[i].UrununYildizi + " Değerlendirme" + " %" + UrunListesi[i].IndirimOrani + " İndirim");
}

Console.WriteLine(" ");
Console.WriteLine("----------Foreach Döngüsü----------");


foreach (var Urunler in UrunListesi)
{
    Console.WriteLine(Urunler.UrununAdi + " " + Urunler.UrununFiyati + "TL  " + Urunler.UrununYildizi + " Değerlendirme" + " %" + Urunler.IndirimOrani + " İndirim");
}

Console.WriteLine(" ");
Console.WriteLine("----------While Döngüsü----------");



int a = 0;
while (a < UrunListesi.Length)
{
    Console.WriteLine(UrunListesi[a].UrununAdi + " " + UrunListesi[a].UrununFiyati + "TL  " + UrunListesi[a].UrununYildizi + " Değerlendirme" + " %" + UrunListesi[a].IndirimOrani + " İndirim");
    a++;
}






class Urunler
{
    public string UrununAdi { get; set; }
    public int UrununFiyati { get; set; }
    public double UrununYildizi { get; set; }
    public double IndirimOrani { get; set; }
