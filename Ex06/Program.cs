using System;

namespace Ex06
{
    internal class Program
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
            else if (num1 == num2)
                Console.WriteLine("Iguales");
            else
                Console.WriteLine("Creciente");
        }
    }
}
