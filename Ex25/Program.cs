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


            double num1, num2, num3;

            Console.WriteLine("num1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("num2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("num3: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3 && num2>= num3)
                Console.WriteLine($"Orden creciente {num3} , {num2} , {num1}");
            else if (num1 <= num2 && num1 <= num3 && num2 <= num3)
                Console.WriteLine($"Orden creciente {num1} , {num2} , {num3}");
            else  if (num2 >= num1 && num2 >= num3 && num1>=3)
                Console.WriteLine($"Orden creciente {num3} , {num1} , {num2}");
            else if (num3>=num2 && num1>=num2)
                Console.WriteLine($"Orden creciente {num2} , {num1} , {num3}");
            else
                Console.WriteLine(($"Orden creciente {num2} , {num3} , {num1}");






        }
    }
}
