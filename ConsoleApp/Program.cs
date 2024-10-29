namespace ConsoleApp
{
    public class Proizvod
    {
        string naziv { get; set; }
        decimal cijena { get; set; }
        int dostupnaKolicina { get; set; }

        public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
        {
            this.naziv = naziv;
            this.cijena = cijena;
            this.dostupnaKolicina = dostupnaKolicina;
        }

        public void ispisi()
        {
            Console.WriteLine($"naziv: {naziv}");
            Console.WriteLine($"cijena: {cijena}");
            Console.WriteLine($"dostupna kolicina: {dostupnaKolicina}");
        }
    }

    public class ElektronickiUredjaj
    {
        string naziv { get; set; }
        string proizvodjac { get; set; }
        int godinaProizvodnje { get; set; }

        public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
        {
            this.naziv = naziv;
            this.proizvodjac = proizvodjac;
            this.godinaProizvodnje = godinaProizvodnje;

        }
        public void ispisi()
        {
            Console.WriteLine($"naziv: {naziv}");
            Console.WriteLine($"proizvodjac: {proizvodjac}");
            Console.WriteLine($"godina proizvodnje: {godinaProizvodnje}");
        }

    }

    public class PametniTelefon : ElektronickiUredjaj
    {
        string operativniSustav {  get; set; }

        public PametniTelefon

    }



        public class Program
    {
        static void Main(string[] args)
        {
                Proizvod proizvod = new Proizvod("gitara", 2000, 15);

                proizvod.ispisi();

                ElektronickiUredjaj el = new ElektronickiUredjaj("friskac", "koncar", 1998);
                el.ispisi();
        }
    }
}
