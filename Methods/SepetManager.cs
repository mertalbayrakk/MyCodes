namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Tebrikler.Sepete Eklendi!" + ": " + urun.Adi);

        }
        public void Ekle2(string urunAdi, string acıklama, double fiyat,
            int stokAdedi)
        {

            Console.WriteLine("Tebrikler. Septe Eklendi : " + urunAdi + acıklama + fiyat + stokAdedi);

        }



    }
}