using System;

namespace ElektronickiUredjajiApp
{
    // Klasa Proizvod
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
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Cijena: {Cijena} KM");
            Console.WriteLine($"Dostupna količina: {DostupnaKolicina}");
        }
    }

    // Bazna klasa ElektronickiUredjaj
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
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Proizvođač: {Proizvodjac}");
            Console.WriteLine($"Godina proizvodnje: {GodinaProizvodnje}");
        }
    }

    // Klasa PametniTelefon
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
            Console.WriteLine($"Instaliram aplikaciju: {nazivAplikacije}");
        }

        public new void IspisiInformacije()
        {
            base.IspisiInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }
    }

    // Glavna klasa Program
    class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje objekta tipa Proizvod
            Proizvod proizvod = new Proizvod("Laptop", 1500.00m, 5);
            proizvod.IspisiInformacije();

            Console.WriteLine(); // Dodaj praznu liniju radi čitljivosti

            // Kreiranje objekta tipa PametniTelefon
            PametniTelefon telefon = new PametniTelefon("iPhone 14", "Apple", 2022, "iOS");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("WhatsApp");
        }
    }
}
