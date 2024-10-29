using System;

public class Proizvod
{
    // Svojstva za klasu Proizvod
    public string Naziv { get; set; }
    public decimal Cijena { get; set; }
    public int DostupnaKolicina { get; set; }

    // Konstruktor za klasu Proizvod
    public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
    {
        Naziv = naziv;
        Cijena = cijena;
        DostupnaKolicina = dostupnaKolicina;
    }

    // Metoda za ispis informacija o proizvodu
    public void IspisiInformacije()
    {
        Console.WriteLine($"Naziv: {Naziv}, Cijena: {Cijena}, Dostupna količina: {DostupnaKolicina}");
    }
}

public class ElektronickiUredjaj
{
    // Svojstva za klasu ElektronickiUredjaj
    public string Naziv { get; set; }
    public string Proizvodjac { get; set; }
    public int GodinaProizvodnje { get; set; }

    // Konstruktor za klasu ElektronickiUredjaj
    public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
    {
        Naziv = naziv;
        Proizvodjac = proizvodjac;
        GodinaProizvodnje = godinaProizvodnje;
    }

    // Metoda za ispis informacija o elektroničkom uređaju
    public void IspisiInformacije()
    {
        Console.WriteLine($"Naziv: {Naziv}, Proizvođač: {Proizvodjac}, Godina proizvodnje: {GodinaProizvodnje}");
    }
}

public class PametniTelefon : ElektronickiUredjaj
{
    // Svojstvo specifično za klasu PametniTelefon
    public string OperativniSustav { get; set; }

    // Konstruktor za klasu PametniTelefon koji poziva bazni konstruktor
    public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
        : base(naziv, proizvodjac, godinaProizvodnje)
    {
        OperativniSustav = operativniSustav;
    }

    // Metoda za instalaciju aplikacije na pametni telefon
    public void InstalirajAplikaciju(string nazivAplikacije)
    {
        Console.WriteLine($"Instaliram aplikaciju: {nazivAplikacije} na {Naziv}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Kreiranje objekta tipa Proizvod i ispis njegovih informacija
        Proizvod proizvod = new Proizvod("Laptop", 7500.99m, 5);
        proizvod.IspisiInformacije();

        Console.WriteLine(); // Prazan red za razdvajanje ispisa

        // Kreiranje objekta tipa PametniTelefon i ispis njegovih informacija
        PametniTelefon telefon = new PametniTelefon("iPhone", "Apple", 2023, "iOS");
        telefon.IspisiInformacije();
        telefon.InstalirajAplikaciju("Viber");
    }
}


