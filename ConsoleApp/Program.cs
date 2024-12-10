namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod("Mobitel", 799.99m, 10);

            proizvod.IspisiInformacije();

            PametniTelefon smartphone = new PametniTelefon("Samsung Galaxy S21", "Samsung", 2021, "Android");

            smartphone.IspisiInformacije();

            smartphone.InstalirajAplikaciju("WhatsApp");

            int a;
            int b;
            int suma, umnozak;
            Console.WriteLine("Unos broja:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            suma = a + b;
            Console.WriteLine(suma);
        }
    }
}
