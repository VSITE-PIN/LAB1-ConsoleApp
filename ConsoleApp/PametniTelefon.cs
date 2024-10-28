using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class PametniTelefon : ElektronickiUredaj
    {
        public string OperativniSustav { get; set; }


        public PametniTelefon(string naziv, string proizvodac, int godinaProizvidnje, string operativniSustav)
            : base(naziv, proizvodac, godinaProizvidnje)
        {
            operativniSustav = operativniSustav;
        }

        public string InstalirajAplikaciju(string app)
        {
            /*Console.WriteLine($"Aplikacija: {app}");*/
            return app;
        }
    }
}
