using System;

namespace DrugiZadatak
{
    public class ElektronickiUredjaj
    {
        // Svojstva klase
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public int GodinaProizvodnje { get; set; }

        // Konstruktor bazne klase
        public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
        }

        // Metoda za ispis informacija o uređaju
        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Proizvođač: {Proizvodjac}");
            Console.WriteLine($"Godina proizvodnje: {GodinaProizvodnje}");
        }
    }

    // Izvedena klasa PametniTelefon koja nasljeđuje ElektronickiUredjaj
    public class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }

        // Konstruktor izvedene klase
        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje) 
        {
            OperativniSustav = operativniSustav;
        }

        // Metoda za instaliranje aplikacije
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instalacija aplikacije: {nazivAplikacije}");
        }

        public new void IspisiInformacije()
        {
            base.IspisiInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }
    }

    public class Program1
    {
        public static void Main1()
        {
            // Kreiranje objekta tipa PametniTelefon
            PametniTelefon telefon = new PametniTelefon("Galaxy S21", "Samsung", 2021, "Android");

            // Pozivanje metoda
            telefon.IspisiInformacije();          
            telefon.InstalirajAplikaciju("WhatsApp"); 
        }
    }
}