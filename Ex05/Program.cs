using System;

namespace ordre_creixent_o_decreixent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fes un programa que ens digui si dos números han estat introduits en ordre creixent

            double num1, num2;

            Console.WriteLine("Primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("Decreciente");
         
             else
                Console.WriteLine("Creciente");








        }
    }
}
