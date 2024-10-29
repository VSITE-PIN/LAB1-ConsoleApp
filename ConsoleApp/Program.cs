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
        {
            PametniTelefon telefon = new PametniTelefon("iPhone", "Apple", 2022, "iOS");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("WhatsApp");
        }
    }
}


public class ElektronickiUredjaj
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
        Console.WriteLine($"Naziv: {Naziv}, Proizvođač: {Proizvodjac}, Godina proizvodnje: {GodinaProizvodnje}");
    }
}

public class PametniTelefon : ElektronickiUredjaj
{
    public string OperativniSustav { get; set; }

    public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
        : base(naziv, proizvodjac, godinaProizvodnje)
    {
        OperativniSustav = operativniSustav;
    }

    public void InstalirajAplikaciju(string nazivAplikacije)
    {
        Console.WriteLine($"Instalirana aplikacija: {nazivAplikacije}");
    }
}