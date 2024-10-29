using ConsoleApp;

namespace ConsoleApp
{
    

        public class Proizvod
        {
            // Definiraj svojstva
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

            // Metoda za ispis informacija
            public void IspisiInformacije()
            {
                Console.WriteLine($"Naziv: {Naziv}, Cijena: {Cijena}, Dostupna količina: {DostupnaKolicina}");
            }
        }

    }
public class Program
{
    static void Main(string[] args)
    {
        // Kreiraj objekt tipa Proizvod
        Proizvod proizvod = new Proizvod("Laptop", 1500.99m, 10);

        // Ispisi informacije o proizvodu
        proizvod.IspisiInformacije();
    }
}

