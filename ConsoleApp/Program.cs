namespace ConsoleApp
{
    public class Program
    {
        static void Main()
        {
            Proizvod proizvod = new Proizvod("Laptop", 999.99m, 10);

            proizvod.IspisiInformacije();
        }
    }
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
            Console.WriteLine($"Cijena: {Cijena:C}");
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

        
        public override void IspisiInformacije()
        {
            base.IspisiInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }

       
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Aplikacija '{nazivAplikacije}' je instalirana na uređaj {Naziv}.");
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
           
            PametniTelefon telefon = new PametniTelefon("Galaxy S21", "Samsung", 2021, "Android");

            
            telefon.IspisiInformacije();

           
            telefon.InstalirajAplikaciju("WhatsApp");
        }
    }

}

