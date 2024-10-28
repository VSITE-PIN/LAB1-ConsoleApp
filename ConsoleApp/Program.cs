using System.Numerics;
using System.IO;


namespace ConsoleApp
{

    public class Proizvod
    {
		
        public string Naziv;
	    public decimal Cijena;
		public int DostupnaKolicina;

        public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
		{
			Naziv = naziv;
			Cijena = cijena;
			DostupnaKolicina = dostupnaKolicina;
		}

        public void IspisiInformacije()
        {
            Console.WriteLine("Naziv proizvoda:" + Naziv +"\n");
            Console.WriteLine("Cijena proizvoda:" + Cijena + "\n");
            Console.WriteLine("Dostupna kolicina:" + DostupnaKolicina + "\n");
        }

	}

	public class ElektronickiUredjaj
	{

		public string Naziv;
		public string Proizvodjac;
		public int GodinaProizvodnje;

		public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
		{
			Naziv = naziv;
			Proizvodjac = proizvodjac;
			GodinaProizvodnje = godinaProizvodnje;
		}

		public void IspisiInformacije()
		{
			Console.WriteLine("Naziv proizvoda:" + Naziv + "\n");
			Console.WriteLine("Proizvodjac proizvoda:" + Proizvodjac + "\n");
			Console.WriteLine("Godina Proizvodnje:" + GodinaProizvodnje + "\n");
		}

	}

	public class PametniTelefon : ElektronickiUredjaj
	{
		public string OperativniSustav;

		public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav) : base(naziv, proizvodjac, godinaProizvodnje)
		{
			Naziv = naziv;
			Proizvodjac= proizvodjac;
			GodinaProizvodnje= godinaProizvodnje;
			OperativniSustav= operativniSustav;
		}

		public void InstalirajAplikaciju(string naziv)
		{
			Console.WriteLine(naziv);
		}
	}

	internal class Program
    {
        static void Main(string[] args)
        {
            Proizvod p = new Proizvod("Mikrofon", (decimal)29.99,60);
            p.IspisiInformacije();

			PametniTelefon pametni = new PametniTelefon("HonorC30", "Huawei", 2017, "Android");
			pametni.IspisiInformacije();
			pametni.InstalirajAplikaciju("hexball");
			
		}
		
	 }
}
