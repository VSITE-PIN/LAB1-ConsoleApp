namespace ConsoleApp;

public class PametniTelefon: ElektronickiUredaj
{
    private string OperativniSustav;

    public PametniTelefon(string naziv, string proizvodac, int godinaProizvodnje, string operativniSustav) :
        base(naziv, proizvodac, godinaProizvodnje)
    {
        this.OperativniSustav = operativniSustav;
    }

    public void InstalirajAplikaciju(string nazivAplikacije)
    {
        Console.WriteLine($"Instalirat cu {nazivAplikacije}");
    }

    public void IsprintajOS()
    {
        Console.WriteLine($"OS je {OperativniSustav}");
    }

}