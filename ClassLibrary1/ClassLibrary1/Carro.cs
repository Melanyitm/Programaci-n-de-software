using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Carro : IVerhiculo
    {
        int ruedas { get; set; }
        public void conducir()
        {
            Console.WriteLine("Conduciendo mi carro");  
        }

        public int numeroRuedas()
        {
            ruedas = 4;
            return ruedas;
        }
    }
}
