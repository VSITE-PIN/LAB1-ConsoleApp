using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ElektronickiUredaj
    {
        public string naziv;
        public string proizvodac;
        public int godinaProizvodnje;
        public ElektronickiUredaj(string naziv,string proizvodac, int godinaProizvodnje)
        {
            naziv = naziv;
            proizvodac = proizvodac;
            godinaProizvodnje = godinaProizvodnje;
        }

        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {naziv}");
            Console.WriteLine($"Proizvodac:{proizvodac}");
            Console.WriteLine($"Godina proizvodnje: {godinaProizvodnje}");
        }
    }
}
