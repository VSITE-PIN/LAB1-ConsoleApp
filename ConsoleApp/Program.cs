
namespace ProizvodiIUredjaji
{
    // Klasa Proizvod
    class Proizvod
    {
        // Svojstva klase
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        // Konstruktor klase Proizvod
        public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }

        // Metoda za ispis informacija o proizvodu
        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Cijena: {Cijena:C}");
            Console.WriteLine($"Dostupna količina: {DostupnaKolicina}");
        }
    }

    // Klasa ElektronickiUredjaj
    class ElektronickiUredjaj
    {
        // Svojstva klase
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public int GodinaProizvodnje { get; set; }

        // Konstruktor klase ElektronickiUredjaj
        public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
        }

        // Metoda za ispis informacija o elektroničkom uređaju
        public virtual void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Proizvođač: {Proizvodjac}");
            Console.WriteLine($"Godina proizvodnje: {GodinaProizvodnje}");
        }
    }

    // Definicija klase PametniTelefon koja nasljeđuje ElektronickiUredjaj
    class PametniTelefon : ElektronickiUredjaj
    {
        // Svojstvo klase
        public string OperativniSustav { get; set; }

        // Konstruktor klase PametniTelefon
        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje) // Poziv konstruktora bazne klase
        {
            OperativniSustav = operativniSustav;
        }

        // Override metode za ispis informacija
        public override void IspisiInformacije()
        {
            base.IspisiInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }

        // Metoda za instalaciju aplikacije
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instalirana aplikacija: {nazivAplikacije}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Dio: Kreiranje objekta tipa Proizvod
            Proizvod proizvod = new Proizvod("Laptop", 7999.99m, 5);
            Console.WriteLine("Informacije o proizvodu:");
            proizvod.IspisiInformacije();

            Console.WriteLine("\n---\n");

            // 2. Dio: Kreiranje objekta tipa PametniTelefon

            PametniTelefon pametniTelefon = new PametniTelefon("Galaxy S23", "Samsung", 2023, "Android");
            Console.WriteLine("Informacije o pametnom telefonu:");
            pametniTelefon.IspisiInformacije();

            // Pozivanje metode za instalaciju aplikacije

            pametniTelefon.InstalirajAplikaciju("PornHub");

            Console.ReadLine(); // Čekanje unosa za zatvaranje konzole
        }
    }
}

