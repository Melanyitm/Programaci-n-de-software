using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Monopatin : IVerhiculo
    {
        int ruedas { get; set; }
        public void conducir()
        {
            Console.WriteLine("Voy en mi Monopatin");
        }
        public int numeroRuedas()
        {
            ruedas = 2;
            return ruedas;
        }
    }
}
