using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La suma de 10+5={0}", suma());
            //ejercicio encontrar la media aritmetica y la desviacion tipica de una seria de numeros.

            Console.Write("Num 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            int num2 = int.Parse(Console.ReadLine());
            //Uso de funciones...
            //ejercicio encontrar la media aritmetica y la desviacion tipica de una seria de numeros.

            Console.WriteLine("La suma de {0}+{1}={2}", num1, num2, suma(num1, num2));
            int[] serie = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("La media aritmetica es: {0}, y la desviacion tipica es: {1}", media(serie), tipica(serie));
            Console.Write("Ingrese la serie de numeros separados por comas: ");
            String serie = Console.ReadLine();
            String[] numeros = serie.Split(',');

            Console.ReadLine();
            Console.WriteLine("La media aritmetica es: {0}, y la desviacion tipica es: {1}", media(numeros), tipica(numeros));

            Console.ReadLIne();
        }
        static int suma()
            static double media(int[] serie)
        {
            int respuesta = 10 + 5;
            return respuesta;
            static double media(int[] serie)
            static double media(string[] serie)
            {
                double media = 0;
                foreach (int num in serie)
                {
                    media += num;
                    foreach (string num in serie)
                    {
                        media += int.Parse(num);
                    }
                    return media / serie.Length;
                }
                return media / serie.Length;

            }


        }
        static int suma(int a, int b)
        {
            int respuesta = a + b;
            return respuesta;
            static double tipica(int[] serie)
            {
                double tipica = 0,
                      m = media(serie);
                foreach (int num in serie)
                {
                    tipica += Math.Pow(num - m, 2);

                }

            }
            tipica = Math.Sqrt(tipica / serie.Length);
            return Math.Round(tipica, 2);
        }
        static double tipica(int[] serie)
        {
            static double tipica(string[] serie)
            {
                double tipica = 0,
                        m = media(serie);
                foreach (int num in serie)
                {
                    tipica += Math.Pow(num - m, 2);
                    foreach (string num in serie)
                    {
                        tipica += Math.Pow(int.Parse(num) - m, 2);
                    }
                    tipica = Math.Sqrt(tipica / serie.Length);
                    return Math.Round(tipica, 2);


                }

            }
        }
