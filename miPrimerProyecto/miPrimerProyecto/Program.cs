using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto
{
    internal class Program
    {
        static int Main(string[] args)
        {
            //uso de funciones..
            Console.WriteLine("La sum de 10+5={0}", suma());
            Console.ReadLine();
            {
                static int suma();
                int respuesta = 10 + 5;
                return respuesta;
            }
        }
    }
}
