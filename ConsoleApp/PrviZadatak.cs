using DrugiZadatak;
using System;

namespace PrviZadatak
{
    public class Proizvod
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        // Konstruktor koji prima naziv, cijenu i dostupnu količinu
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
            Console.WriteLine($"Cijena: {Cijena} eura");
            Console.WriteLine($"Dostupna količina: {DostupnaKolicina}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje objekta tipa Proizvod
            Proizvod proizvod = new Proizvod("Laptop", 1300, 10);

            proizvod.IspisiInformacije();

            Program1.Main1();
        }
    }
}