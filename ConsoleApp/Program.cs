using System;

namespace ConsoleApp
{
    internal class Proizvod
    {
        public string naziv;
        public decimal cijena;
        public int dostupnaKolicina;

        public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
        {
            this.naziv = naziv;
            this.cijena = cijena;
            this.dostupnaKolicina = dostupnaKolicina;
        }

        public void IspisInfomracija()
        {
            Console.WriteLine($"Naziv je {naziv}");
            Console.WriteLine($"Cijena je {cijena}");
            Console.WriteLine($"Dostupna kolicina je {dostupnaKolicina}");
        }
    }

    internal class ElektronickiUredjaj
    {
        public string naziv;
        public string proizvodjac;
        public int godinaProizvodnje;

        public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
        {
            this.naziv = naziv;
            this.proizvodjac = proizvodjac;
            this.godinaProizvodnje = godinaProizvodnje;
        }

        public virtual void IspisiInformacije()
        {
            Console.WriteLine($"Naziv je {naziv}");
            Console.WriteLine($"Proizvođač je {proizvodjac}");
            Console.WriteLine($"Godina proizvodnje je {godinaProizvodnje}");
        }
    }

    internal class PametniTelefon : ElektronickiUredjaj
    {
        public string operativniSustav;

        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje)
      {
           this.operativniSustav = operativniSustav;
       }

        public void InstalirajAplikaciju(string nazivAplikacije)
       {
           Console.WriteLine($"instal aplikacije pod nazivom {nazivAplikacije} na {operativniSustav}");
      }

        public override void IspisiInformacije()
       {
            base.IspisiInformacije();
            Console.WriteLine($"Operativni sustav je {operativniSustav}");
       }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod("Telefon", 199.99m, 72);
            proizvod.IspisInfomracija();

            PametniTelefon telefon = new PametniTelefon("IPhone", "apple", 2024, "iOS");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("WhatsApp");
      }
   }
}
