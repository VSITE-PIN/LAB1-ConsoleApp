namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod("Čokoladni prutić", 1.5m, 350);
            proizvod.IspisiInformacije(proizvod);
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
        Console.WriteLine($"Naziv={Naziv}, Cijena {Naziv} iznosi {Cijena} eura, a dostupna količina je {DostupnaKolicina}");
    }
}
