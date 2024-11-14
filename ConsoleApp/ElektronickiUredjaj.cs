using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
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
        public virtual void IspisInformacije()
        {
            Console.WriteLine("Naziv: " + Naziv);
            Console.WriteLine("Proizvođač: " + Proizvodjac);
            Console.WriteLine("Godina proizvodnje: " + GodinaProizvodnje);
        }
    }
    public class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }
        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav) : base(naziv, proizvodjac, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav;
        }
        public override void IspisInformacije()
        {
            base.IspisInformacije();
            Console.WriteLine("Operativni sustav: " + OperativniSustav);
        }
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine("Instalirana aplikacija: " + nazivAplikacije);
        }
        class Program
        {
            static void Main(string[] args)
            {
                PametniTelefon telefon = new PametniTelefon("Pura70", "Huawei", 2024, "Android");
                telefon.IspisInformacije();
                telefon.InstalirajAplikaciju("Google Play");
            }
        }

    }
}
