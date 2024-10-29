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
        Console.WriteLine($"Naziv: {Naziv}, Cijena: {Cijena}, Dostupna količina: {DostupnaKolicina}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Proizvod p = new Proizvod("USB", 8.59m, 50);
        p.IspisiInformacije();
    }
}
