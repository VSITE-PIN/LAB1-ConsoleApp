using System;

namespace ConsoleApp
{
    internal class Program
    {
        public class Proizvod
        {
            public string Naziv { get; set; }
            public decimal Cijena { get; set; }
            public int DostupnaKolicina { get; set; }

            public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
            {
                Naziv = naziv;
                Cijena = cijena;
                DostupnaKolicina = dostupnaKolicina;
            }

            public void IspisiInformacije()
            {
                Console.WriteLine($"Naziv: {Naziv}");
                Console.WriteLine($"Cijena: {Cijena:F2}");
                Console.WriteLine($"Dostupna količina: {DostupnaKolicina}");
            }
        }

        public class ElektronickiUredaj
        {
            public string Naziv { get; set; }
            public string Proizvodac { get; set; }
            public int GodinaProizvodnje { get; set; }

            public ElektronickiUredaj(string naziv, string proizvodac, int godinaProizvodnje)
            {
                Naziv = naziv;
                Proizvodac = proizvodac;
                GodinaProizvodnje = godinaProizvodnje;
            }

            public void IspisiInformacije()
            {
                Console.WriteLine($"Naziv: {Naziv}");
                Console.WriteLine($"Proizvodac: {Proizvodac}");
                Console.WriteLine($"Godina Proizvodnje: {GodinaProizvodnje}");
            }
        }
        public class PametniTelefon : ElektronickiUredaj
        {
            public string OperativniSustav { get; set; }


            public PametniTelefon(string naziv, string proizvodac, int godinaProizvodnje, string operativniSustav)
                : base(naziv, proizvodac, godinaProizvodnje)
            {
                OperativniSustav = operativniSustav;
            }

            public void InstalirajAplikaciju(string nazivAplikacije)
            {
                Console.WriteLine($"Instaliram aplikaciju: {nazivAplikacije}");
            }

            public new void IspisiInformacije()
            {
                base.IspisiInformacije();
                Console.WriteLine($"Operativni sustav: {OperativniSustav}");
            }
        }

        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod("Laptop", 999.99m, 5);
            proizvod.IspisiInformacije();

            ElektronickiUredaj uredaj = new ElektronickiUredaj("Pametan netelefon", "kkkkkl", 2023);
            uredaj.IspisiInformacije();

            PametniTelefon telefon = new PametniTelefon("Pametan telefon", "Proizvođač XYZ", 2023, "Android");
            telefon.IspisiInformacije();

            telefon.InstalirajAplikaciju("ovu");
        }
    }
}
