using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Program
    {

        static void Main(string[] arg)
        {
            IVerhiculo[] verhiculos = new IVerhiculo[2];
            verhiculos[0] = new Carro();
            verhiculos[1] = new Moto();

            foreach (IVerhiculo v in verhiculos)
            {
                v.conducir();
            }
        }
    }

}