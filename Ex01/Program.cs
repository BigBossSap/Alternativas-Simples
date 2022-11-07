using System;

namespace ecuacion_primer_grado
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Fes un programa en c# que calculi la solució de l’equació de primer grau. ax+b=0 . Ha
de controlar quan la a és zero. */ 

            double a, b;
            double resultado;

            Console.WriteLine("a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
                Console.WriteLine("Imposible dividir por 0");

            else
            {

                resultado = -b / a;
                Console.WriteLine(resultado);
            }


          
        }
    }
}
