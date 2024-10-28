namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proizvod p1 = new Proizvod();
            p1.IspisInformacije("tablet", 1000.99m, 5);

            PametniTelefon t1 = new PametniTelefon("Samsung S23", "Samsung", 2023, "Android");
            t1.InstalirajAplikaciju("twitter");
        }
    }
}
