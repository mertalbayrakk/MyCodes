using System.Runtime.InteropServices;


//type safety-tip güvenliği
//Değer tutucu, alias

//tam sayı eklerken int koyuyoruz.
//Ondalıklı sayı eklerken double koyuyoruz.
//değişken eklerken string koyuyoruz.

string Kategoriler = "Kategori";

int ogrenciSayisi = 32000;

double faizOranı = 1.65;

bool sistemeGirisYapılmisMi = true;

double dolarDun = 7.45;
double dolarBugun = 7.2;

if (dolarBugun < dolarDun)
{
    Console.WriteLine("Azalış Oku");

}

else if (dolarBugun > dolarDun)
{
    Console.WriteLine("Artış Oku");

}

else
{
    Console.WriteLine("Değişmedi");
}





if (sistemeGirisYapılmisMi == true)
{
    Console.WriteLine("Kullanı ayarları butonu");
}
else
{
    Console.WriteLine("Giris Yap Butonu");
}





Console.WriteLine(Kategoriler);

