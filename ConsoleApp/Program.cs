using ConsoleApp;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje novog proizvoda
            Proizvod proizvod = new Proizvod("Laptop", 5999.99m, 10);

            // Kreiranje novog elektroničkog uređaja
            ElektronickiUredjaj uredjaj = new ElektronickiUredjaj("Laptop", "Dell", 2021);

            // Prikaz informacija o proizvodu
            proizvod.IspisiInformacije();

            // Kreiranje objekta tipa PametniTelefon
            PametniTelefon telefon = new PametniTelefon("Galaxy S21", "Samsung", 2021, "Android");

            // Ispis informacija o pametnom telefonu
            telefon.IspisiInformacije();

            // Instalacija aplikacije
            telefon.InstalirajAplikaciju("WhatsApp");
            telefon.InstalirajAplikaciju("Spotify");
        }

    }

}
