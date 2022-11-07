using System;

namespace ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fes un programa que ens demani la operació que volem fer (+, -, * ó /), dos valors i mostri el
 resultat pertinent.*/

            string operativo;
            double a, b;
            double res1, res2, res3, res4;


            Console.WriteLine("Introduce la operación a realizar (+,-,*,/)");
            operativo = Console.ReadLine();
            Console.WriteLine("Primer numero");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo numero");
            b = Convert.ToDouble(Console.ReadLine());

            if (operativo == "+")
            {
                res1 = Convert.ToDouble(a + b);
                Console.WriteLine(res1);


            }
            else if (operativo == "-")
            {
                res2 = Convert.ToDouble(a - b);
                Console.WriteLine(res2);
            }

            else if (operativo == "*")
            {
                res3 = Convert.ToDouble(a * b);
                Console.WriteLine(res3);
            }
            else if (operativo == "/")
            {
                res4 = Convert.ToDouble(a / b);
                Console.WriteLine(res4);
            }
        }
    }
}
