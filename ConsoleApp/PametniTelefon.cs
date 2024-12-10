using System;

class PametniTelefon : ElektronickiUredjaj
{
    public string OperativniSustav { get; set; }

    public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string os)
        : base(naziv, proizvodjac, godinaProizvodnje)
    {
        OperativniSustav = os;
    }

    public void InstalirajAplikaciju(string nazivAplikacije)
    {
        Console.WriteLine($"Instaliram aplikaciju: {nazivAplikacije}");
    }
}