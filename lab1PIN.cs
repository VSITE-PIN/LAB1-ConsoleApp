public class Proizvod
{
    // Svojstva klase
    public string Naziv { get; set; }
    public decimal Cijena { get; set; }
    public int DostupnaKolicina { get; set; }

    // Konstruktor
    public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
    {
        Naziv = naziv;
        Cijena = cijena;
        DostupnaKolicina = dostupnaKolicina;
    }

    // Metoda za prikaz informacija o proizvodu
    public void PrikaziInformacije()
    {
        Console.WriteLine($"Naziv: {Naziv}");
        Console.WriteLine($"Cijena: {Cijena} kn");
        Console.WriteLine($"Dostupna količina: {DostupnaKolicina}");
    }
}

// Klasa Program
public class Program
{
    static void Main(string[] args)
    {
        // Kreiranje novog proizvoda
        Proizvod proizvod = new Proizvod("Laptop", 5999.99m, 10);

        // Prikaz informacija o proizvodu
        proizvod.PrikaziInformacije();
    }
}