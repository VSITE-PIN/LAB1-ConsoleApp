namespace ConsoleApp;

public class Proizvodi
{
    private string Naziv;
    private decimal Cijena;
    private int DostupnaKolcina;

    public Proizvodi(string naziv, decimal cijena, int dostupnaKolicina)
    {
        Naziv = naziv;
        Cijena = cijena;
        DostupnaKolcina = dostupnaKolicina;
    }

    public void IspisInformacije()
    {
        Console.WriteLine($"Naziv proizvoda je {Naziv}, cijena mu je {Cijena}e, a dostupna kolicina je {DostupnaKolcina}kom");
    }
}