using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Moto : IVerhiculo

    {
        int ruedas { get; set; }
        public void conducir()
        {
            Console.WriteLine("Conduciendo mi moto");
        }

        public int numeroRuedas()
        {
            ruedas = 2;
            return ruedas;
        }
    }
}
