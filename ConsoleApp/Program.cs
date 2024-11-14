namespace ConsoleApp
{

    public class Proizvod
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }

        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}, Cijena: {Cijena}, Dostupna količina: {DostupnaKolicina}");
        }
    }

    public class ElektronickiUredjaj
    {
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public int GodinaProizvodnje { get; set; }

        public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
        }

        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}, Proizvođač: {Proizvodjac}, Godina proizvodnje: {GodinaProizvodnje}");
        }
    }

    public class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }

        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav;
        }

        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instaliranje aplikacije: {nazivAplikacije}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Kreiranje objekta tipa Proizvod
            Proizvod proizvod = new Proizvod("Laptop", 4999.99m, 10);
            proizvod.IspisiInformacije();

            // Kreiranje objekta tipa PametniTelefon
            PametniTelefon telefon = new PametniTelefon("Galaxy S22", "Samsung", 2022, "Android");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("WhatsApp");

            // Konzola ostaje otvorena dok ne pritisnete tipku
            Console.ReadKey();
        }
    }

}
