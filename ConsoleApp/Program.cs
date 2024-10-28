using System;
namespace ConsoleApp
{
    // 1. KLASE I OBJEKTI
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
            Console.WriteLine($"Naziv: {Naziv}, Cijena: {Cijena} kn, Dostupna količina: {DostupnaKolicina}");
        }
    }

    // 2. NASLJEĐIVANJE
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
            Console.WriteLine($"Naziv: {Naziv}, Proizvođač: {Proizvodjac}, Godina proizvodnje: {GodinaProizvodnje}");
        }
    }

    public class PametniTelefon : ElektronickiUredjaj
    {
        // Svojstvo specifično za klasu PametniTelefon
        public string OperativniSustav { get; set; }

        // Konstruktor
        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav;
        }

        // Metoda za instaliranje aplikacije
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instalirana aplikacija: {nazivAplikacije}");
        }

        // Nadjačana metoda za ispis informacija
        public override void IspisiInformacije()
        {
            base.IspisiInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje i ispis objekta Proizvod
            Proizvod proizvod = new Proizvod("Laptop", 8999.99m, 5);
            proizvod.IspisiInformacije();

            Console.WriteLine();

            // Kreiranje i ispis objekta PametniTelefon
            PametniTelefon telefon = new PametniTelefon("Galaxy S21", "Samsung", 2021, "Android");
            telefon.IspisiInformacije();

            // Poziv metode za instalaciju aplikacije
            telefon.InstalirajAplikaciju("WhatsApp");

            Console.ReadLine();
        }
    }
}


