namespace ConsoleApp
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
        public void PrikaziDetalje()
        {
            Console.WriteLine($"Naziv: {Naziv}, Cijena: {Cijena:C}, Dostupna Količina: {DostupnaKolicina}");
        }
        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv : {Naziv}");
            Console.WriteLine($"Cijena: {Cijena}");
            Console.WriteLine($"Dostupna kolicina: {DostupnaKolicina}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod("Laptop", 1200.50m, 5);

            proizvod.IspisiInformacije();

            PametniTelefon telefon = new PametniTelefon("Galaxy S21", "Samsung", 2021, "Android");

            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("WhatsApp");
        }
    }

    public class ElektronickiUredjaj
    {
        public string Naziv { get; set; }
        public string Proizvod { get; set; }
        public int GodinaProizvodnje { get; set; }

        public ElektronickiUredjaj(string naziv, string proizvod, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvod = proizvod;
            GodinaProizvodnje = godinaProizvodnje;
        }
        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}");
            Console.WriteLine($"Proizvođač: {Proizvod}");
            Console.WriteLine($"Godina proizvodnje: {GodinaProizvodnje}");
        }
    }
    public class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }
        public PametniTelefon(string naziv, string proizvod, int godinaProizvodnje, string operativniSustav)
           : base(naziv, proizvod, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav;
        }
        public new void IspisiInformacije()
        {
            base.IspisiInformacije();
            Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        }
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instaliranje aplikacije: {nazivAplikacije}");
        }
    }
}



