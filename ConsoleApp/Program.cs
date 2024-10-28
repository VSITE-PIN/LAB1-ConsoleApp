// 1. zadatak
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
        Console.WriteLine($"Cijena: {Cijena} KM");
        Console.WriteLine($"Dostupna količina: {DostupnaKolicina}");
    }
}
// 2. zadatak
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

    public void IspisiInformacije()
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
        Console.WriteLine($"Instaliram aplikaciju: {nazivAplikacije}");
    }
}
class Ispis
{
    static void Main(string[] args)
    {
        Proizvod proizvod = new Proizvod("Laptop", 125, 10);
        proizvod.IspisiInformacije();

        PametniTelefon telefon = new PametniTelefon("iPhone 16", "Apple", 2024, "IOS");
        telefon.IspisiInformacije();
        Console.WriteLine($"Operativni sustav: {telefon.OperativniSustav}");
        telefon.InstalirajAplikaciju("waze");
    }
}
