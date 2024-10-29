using System;

namespace ProizvodApp
{
    // Klasa Proizvod
    public class Proizvod
    {
        // Svojstva
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
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Cijena: {Cijena} KM");
            Console.WriteLine($"Dostupna količina: {DostupnaKolicina}");
        }
    }

    // Bazna klasa ElektronickiUredjaj
    public class ElektronickiUredjaj
    {
        // Svojstva
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public int GodinaProizvodnje { get; set; }

        // Konstruktor
        public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
        }

        // Metoda za ispis informacija
        public virtual void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Proizvođač: {Proizvodjac}");
            Console.WriteLine($"Godina proizvodnje: {GodinaProizvodnje}");
        }
    }

    // Klasa PametniTelefon koja nasljeđuje ElektronickiUredjaj
    public class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }

        // Konstruktor
        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav;
        }

        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instaliram aplikaciju: {nazivAplikacije}");
        }

        public override void IspisiInformacije()
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
            Proizvod proizvod = new Proizvod("Laptop", 1500.00m, 10);
            proizvod.IspisiInformacije();

            // Kreiranje objekta tipa PametniTelefon
            PametniTelefon telefon = new PametniTelefon("iPhone 14", "Apple", 2022, "iOS");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("WhatsApp");

            // Čekanje da korisnik pritisne tipku
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }
    }
}
