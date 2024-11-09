namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod("Kava", 20.99m, 3);
            proizvod.IspisiInformacije();
            ElektronickiUredjaj uredjaj = new ElektronickiUredjaj("Slušalice", "Sony", 2022);
            uredjaj.IspisiInformacije();
            PametniTelefon telefon = new PametniTelefon("Galaxy S24","Samsung", 2023, "Android");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("Google Karte");
            
        }
    }
}
