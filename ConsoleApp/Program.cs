namespace ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Proizvodi p = new Proizvodi("Neki proizvod", 1920, 4);
            p.IspisInformacije();

            PametniTelefon nekiTelefon = new PametniTelefon("Extreme", "Samsung", 2024, "Android");
            nekiTelefon.IspisInformacije();
            nekiTelefon.InstalirajAplikaciju("TodoMath.");
            nekiTelefon.IsprintajOS();
        }
    }
}
