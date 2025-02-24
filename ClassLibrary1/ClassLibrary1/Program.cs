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
            IVerhiculo[] verhiculos = new IVerhiculo[3];
            verhiculos[0] = new Carro();
            verhiculos[1] = new Moto();
            verhiculos[2] = new Monopatin();

            foreach (IVerhiculo v in verhiculos)
            {
                v.conducir();
            }
        }
    }

}