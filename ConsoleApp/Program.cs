namespace ConsoleApp
{
    class Proizvod
    {
        public string Naziv;
        public double Cijena;
        public int DostupnaKolicina;

        public Proizvod (string naziv, double cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }

        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Cijena: {Cijena} €");
            Console.WriteLine($"Dostupna Količina: {DostupnaKolicina}");
        }
    }

    class ElektronickiUredjaj
    {
        public string Naziv;
        public string Proizvodjac;
        public int GodinaProizvodnje;

        public ElektronickiUredjaj(string naziv, string proizvodjac, int godProizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godProizvodnje;
        }

        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Proizvodjac: {Proizvodjac}");
            Console.WriteLine($"Godina proizvodnje: {GodinaProizvodnje}");
        }
    }

    class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav;

        public PametniTelefon(string naziv, string proizvodjac, int godProizvodnje, string opSustav) : base(naziv, proizvodjac, godProizvodnje)
        {
            OperativniSustav = opSustav;
        }

        public void InstalirajAplikaciju(string nazivAp)
        {
            Console.WriteLine($"Instaliranje aplikacije: {nazivAp}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod("Mobitel", 1499.99, 10);
            proizvod.IspisiInformacije();
            PametniTelefon smartphone = new PametniTelefon("Iphone 16", "Apple", 2024, "MacOS");
            smartphone.IspisiInformacije();
            smartphone.InstalirajAplikaciju("Rezultati");
        }
    }
}
