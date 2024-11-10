using System;

namespace ConsoleApp
{
    class Proizvod
    {
        public string Naziv { get; private set; }
        public decimal Cijena { get; private set; }
        public int DostupnaKolicina { get; private set; }

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
            Console.WriteLine("Naziv: " + Naziv);
            Console.WriteLine("Cijena: " + Cijena + " EUR");
            Console.WriteLine("Dostupna količina: " + DostupnaKolicina);
        }
    }

    class ElektronickiUredjaj
    {
        public string Naziv { get; private set; }
        public string Proizvodjac { get; private set; }
        public int GodinaProizvodnje { get; private set; }

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
            Console.WriteLine("Naziv: " + Naziv);
            Console.WriteLine("Proizvođač: " + Proizvodjac);
            Console.WriteLine("Godina proizvodnje: " + GodinaProizvodnje);
        }
    }

    class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; private set; }

        // Konstruktor
        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav;
        }

        // Metoda za instaliranje aplikacije
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine("Instalacija aplikacije: " + nazivAplikacije);
        }

        // Nadjačana metoda za ispis informacija
        public override void IspisiInformacije()
        {
            base.IspisiInformacije();
            Console.WriteLine("Operativni sustav: " + OperativniSustav);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Zadatak 1: Kreiranje i ispis informacija o Proizvod
            Proizvod proizvod = new Proizvod("Laptop", 1200.50m, 10);
            proizvod.IspisiInformacije();

            Console.WriteLine();

            // Zadatak 2: Kreiranje i ispis informacija o PametniTelefon
            PametniTelefon telefon = new PametniTelefon("iPhone", "Apple", 2023, "iOS");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("WhatsApp");
        }
    }
}

