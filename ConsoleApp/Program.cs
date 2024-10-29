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
        }
    }
}

    
