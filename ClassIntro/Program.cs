Kurs kurs1 = new Kurs();
kurs1.KursAdi = "python";
kurs1.Egitmen = "Mert Albayrak";
kurs1.İzlenmeOrani = 74;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "c#";
kurs2.Egitmen = "Mustafa Kurt";
kurs2.İzlenmeOrani = 55;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Java";
kurs3.Egitmen = "Aleyna Kaplan";
kurs3.İzlenmeOrani = 84;

Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen + "  İzlenme Oranı:" + kurs.İzlenmeOrani);
}





class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int İzlenmeOrani { get; set; }
}
