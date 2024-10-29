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

        class Program
        {
            static void Main(string[] args)
            {
                Proizvod proizvod = new Proizvod("Telefon", 199.99m, 72);
                proizvod.IspisInfomracija();
            }
        }
    }
}
