namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod("Čokoladni prutić", 1.5m, 350);
            proizvod.IspisiInformacije();

            PametniTelefon mobitel = new PametniTelefon("iPhone", "Apple", 2024, "iOS");

            mobitel.ElIspisiInformacije();
            mobitel.InstalirajAplikaciju("WhatsApp");
        }
    }
}

class Proizvod
{
    public string Naziv;
    public decimal Cijena;
    public int DostupnaKolicina;

    public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
    {
        this.Naziv = naziv;
        this.Cijena = cijena;
        this.DostupnaKolicina = dostupnaKolicina;
    }

    public void IspisiInformacije()
    {
        Console.WriteLine($"Naziv artikla je {Naziv}, Cijena artikla iznosi {Cijena} eura, a dostupna količina je {DostupnaKolicina}");
    }
}
class ElektronickiUredjaj
    {
        public string Naziv;
        public string Proizvodjac;
        public int GodinaProizvodnje;

        public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
        {
            this.Naziv= naziv;
            this.Proizvodjac= proizvodjac;
            this.GodinaProizvodnje= godinaProizvodnje;
        }

        public void ElIspisiInformacije()
        {
            Console.WriteLine($"Naziv uredjaja je {Naziv}, proizveo ga je {Proizvodjac} {GodinaProizvodnje}. godine."); 
        }
    }

class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav;

        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
          :base(naziv, proizvodjac, godinaProizvodnje)
        {
            
            this.OperativniSustav = operativniSustav;
        }
        
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instalirana ja {nazivAplikacije} aplikacija na Vaš mobilni uređaj.");
        }
    }      

