using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Proizvod
    {
        public string naziv;
        public decimal cijena;
        public int dostupnaKolicina;
        public Proizvod() 
        {
            naziv = naziv;
            cijena = cijena;
            dostupnaKolicina = dostupnaKolicina;
        }

        public void IspisInformacije(string naziv, decimal cijena, int dostupnaKolicina)
        {
            Console.WriteLine($"Naziv: {naziv}");
            Console.WriteLine($"Cijena:{cijena}");
            Console.WriteLine($"Kolicina: {dostupnaKolicina}");
        }

    }
}
