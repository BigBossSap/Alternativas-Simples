using System;

namespace Ex26
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 26. Fes un programa que demani un número de màxim 4 xifres i escrigui les xifres per separat. */

            
            int numeroCompleto, num1, num2, num3, num4;

            Console.WriteLine("Introduce un numero de 4 cifras:");
            numeroCompleto = Convert.ToInt32(Console.ReadLine());
            

            num1 = numeroCompleto / 1000;
            num2 = numeroCompleto / 100 % 10; 
            num3 = numeroCompleto % 100 / 10;
            num4 = numeroCompleto % 10;
            
            

            Console.WriteLine($"num1: {num1}, num2: {num2}, num3: {num3}, num4: {num4}");



        }
    }
}
