using System;

namespace ConsoleApp
{
    internal class Proizvod
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

        // Metoda za ispis informacija o proizvodu
        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Cijena: {Cijena} kn");
            Console.WriteLine($"Dostupna količina: {DostupnaKolicina}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje objekta klase Proizvod
            Proizvod proizvod = new Proizvod("Laptop", 7500.99m, 5);

            // Ispisivanje informacija o proizvodu
            proizvod.IspisiInformacije();
        }
    }
}


