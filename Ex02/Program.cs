using System;

namespace ecuacion_2ndo_grado_net_4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fes un programa que calculi les solucions d’una equació de segon grau i que no falli mai.
No es poden fer arrels de valors negatius ni divisions per 0.
ax
2
+bx+c=0 → x=
−b±√b
2−4 ac
2 a
*/
            double a, b, c;

            double sol1, sol2;

            Console.WriteLine("a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("c: ");
            c = Convert.ToDouble(Console.ReadLine());



            //ALG

            if (a == 0 || b * b - 4 * a * c < 0)
                Console.WriteLine("Imposible operar");

            else 
            {

                sol1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

                sol2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

                Console.WriteLine(sol1 + " y " + sol2);

            }




        }
    }
}
