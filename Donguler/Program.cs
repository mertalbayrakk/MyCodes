//array-dizi

string[] kurslar = new string[] { "kurs1", "kurs2", "kurs3" };


//foreach- Liste elamanlarını tek tek dönmeye yarar.

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("foreach Bitti");


for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}


