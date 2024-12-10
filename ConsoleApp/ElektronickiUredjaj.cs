using System;

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
