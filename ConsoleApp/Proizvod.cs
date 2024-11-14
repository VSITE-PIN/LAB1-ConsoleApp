using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Proizvod
    {
        public string Naziv {  get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        public Proizvod(string naziv, decimal cijena, int dostupnakolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnakolicina;
        }
        public void IspisInformacije()
        {
            Console.WriteLine("Naziv: " + Naziv);
            Console.WriteLine("Cijena: " + Cijena + " EUR");
            Console.WriteLine("Dostupna količina: " + DostupnaKolicina + " KOM");
        }
        class Program
        {
            static void Main()
            {
                Proizvod proizvod = new Proizvod("Banane", 2, 7);
                proizvod.IspisInformacije();
            }
        }
    }
}
