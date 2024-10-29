using System;

namespace ConsoleApp
{
    public class Proizvod
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }
        public Proizvod(string NazivProizvoda, decimal CijenaProizvoda, int DostupnaKolicinaProizvoda)
        {
            Naziv = NazivProizvoda;
            Cijena = CijenaProizvoda;
            DostupnaKolicina = DostupnaKolicinaProizvoda;
        }
        public void IspisInformacije()
        {
            Console.WriteLine("Naziv: " + Naziv);
            Console.WriteLine("Cijena: " + Cijena);
            Console.WriteLine("Dostupna kolicina: " + DostupnaKolicina);
        }
    }
    public class ElektronickiUredjaj
    {
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public int GodinaProizvodnje { get; set; }
        public ElektronickiUredjaj(string NazivUredjaja, string ProizvodjacUredjaja, int GodinaProizvodnjeUredjaja)
        {
            Naziv = NazivUredjaja;
            Proizvodjac = ProizvodjacUredjaja;
            GodinaProizvodnje = GodinaProizvodnjeUredjaja;
        }
        public void IspisInformacije()
        {
            Console.WriteLine("Naziv: " + Naziv);
            Console.WriteLine("Proizvodjac: " + Proizvodjac);
            Console.WriteLine("Godina proizvodnje: " + GodinaProizvodnje);
        }
    }
    public class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }
        public PametniTelefon(string NazivUredjaja, string ProizvodjacUredjaja, int GodinaProizvodnjeUredjaja, string OperativniSustavUredjaja) : base(NazivUredjaja, ProizvodjacUredjaja, GodinaProizvodnjeUredjaja)
        {
            OperativniSustav = OperativniSustavUredjaja;
        }
        public void InstalirajAplikaciju(string NazivAplikacije)
        {
            base.IspisInformacije();
            Console.WriteLine("Operativni sustav: " + OperativniSustav);
            Console.WriteLine("Naziv aplikacije: " + NazivAplikacije);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod_1 = new Proizvod("Persil", 8, 14);
            proizvod_1.IspisInformacije();

            PametniTelefon telefon = new PametniTelefon("Galaxy S21", "Samsung", 2021, "Android");

            telefon.InstalirajAplikaciju("WhatsApp");


        }
    }
}