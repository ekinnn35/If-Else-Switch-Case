Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");

Console.WriteLine("\nHangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");
string secim = Console.ReadLine().ToLower(); // Küçük harfe dönüştürerek karşılaştırmayı kolaylaştırır

int fiyat;

if (secim == "elma")
{
    fiyat = 2;
}
else if (secim == "armut")
{
    fiyat = 3;
}
else if (secim == "çilek")
{
    fiyat = 2;
}
else if (secim == "muz")
{
    fiyat = 3;
}
else
{
    fiyat = 4;
}

Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {fiyat} TL");

