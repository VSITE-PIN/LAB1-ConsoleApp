namespace ConsoleApp;

public class ElektronickiUredaj
{
    private string Naziv;
    private string Proizvodac;
    private int GodinaProizvodnje;

    public ElektronickiUredaj(string naziv, string proizvodac, int godinaProizvodnje)
    {
        Naziv = naziv;
        Proizvodac = proizvodac;
        GodinaProizvodnje = godinaProizvodnje;
    }

    public void IspisInformacije()
    {
        Console.WriteLine($"Naziv uredaja je {Naziv} od proizvodaca {Proizvodac}, a godina proizvodnje mu je {GodinaProizvodnje}.");
    }
}