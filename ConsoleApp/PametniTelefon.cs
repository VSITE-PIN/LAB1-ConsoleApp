using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class PametniTelefon : ElektronickiUredjaj
    {
        // Novo svojstvo specifično za PametniTelefon
        public string OperativniSustav { get; set; }

        // Konstruktor koji prima naziv, proizvođača, godinu proizvodnje i operativni sustav
        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje) // Poziv konstruktora bazne klase
        {
            OperativniSustav = operativniSustav; // Postavljanje vrijednosti za operativni sustav
        }

        // Metoda koja ispisuje naziv aplikacije koja se instalira
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instalacija aplikacije: {nazivAplikacije} na {Naziv} sa OS-om {OperativniSustav}");
        }

        // Opcionalno: Nadjačana metoda za ispis informacija (dodaje OS informacije)
        public new void IspisiInformacije()
        {
            base.IspisiInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }
    }
}

