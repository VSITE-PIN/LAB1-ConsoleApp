namespace ConsoleApp
{
    // Prvi zadatak
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
            Console.WriteLine($"Naziv: {Naziv}, Cijena: {Cijena} EUR, Dostupna količina: {DostupnaKolicina}");
        }
    }

    // Drugi zadatak
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

        public virtual void IspisiInformacije()
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

        public override void IspisiInformacije()
        {
            base.IspisiInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }

        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instalacija aplikacije: {nazivAplikacije}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod("Laptop", 1500.99m, 5);
            proizvod.IspisiInformacije();

            PametniTelefon telefon = new PametniTelefon("iPhone 16", "Apple", 2024, "iOS");

            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("Telegram");
        }
    }
}