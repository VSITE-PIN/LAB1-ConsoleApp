namespace ConsoleApp
{
    using System;


    class Proizvod
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
            Console.WriteLine($"Cijena: {Cijena} kn");
            Console.WriteLine($"Dostupna količina: {DostupnaKolicina}");
        }
    }


    class ElektronickiUredjaj
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

   
        public virtual void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Proizvođač: {Proizvodjac}");
            Console.WriteLine($"Godina proizvodnje: {GodinaProizvodnje}");
        }
    }

    
    class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }

   
        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav;
        }

    
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Aplikacija {nazivAplikacije} je instalirana na {Naziv}.");
        }

       
        public override void IspisiInformacije()
        {
            base.IspisiInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Proizvod proizvod = new Proizvod("Laptop", 12200.00m, 3000);
            Console.WriteLine("Informacije o proizvodu:");
            proizvod.IspisiInformacije();
            Console.WriteLine();

       
            PametniTelefon telefon = new PametniTelefon("iPhone 19", "Apple", 2029, "iOS");
            Console.WriteLine("Informacije o pametnom telefonu:");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("WhatsApp");
        }
    }

}
