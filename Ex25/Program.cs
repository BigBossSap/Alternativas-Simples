using System;

namespace Ex25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 25. Fes un programa que donats tres números, els ordeni creixentment. Ha de permutar el valor
de les variables si cal.
*/


            double num1, num2, num3, aux;

            Console.WriteLine("num1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("num2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("num3: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            
            if (num2 < num1)
            {
                aux = num1;
                num1 = num2;
                num2 = aux;
            
            }

            if (num3 < num2) 
            {

                aux = num2;
                num2 = num3;
                num3 = aux;
            }

            if (num2 < num1)
            {
                aux = num1;
                num1 = num2;
                num2 = aux;

            }

            Console.WriteLine($"Numeros ordenados: {num1}, {num2}, {num3}");

        }
    }
}
