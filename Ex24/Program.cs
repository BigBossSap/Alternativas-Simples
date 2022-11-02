using System;

namespace Ex24
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 24. Fes un programa que donat un nombre de fins a 3 xifres (té 1, 2 ó 3 xifres), digui si és cap-icua.*/

            int num, num1, num2, num3;

            Console.WriteLine("Introduce un numero de 3 cifras: ");
            num = Convert.ToInt32(Console.ReadLine());
            num1 = num / 100;
            num2 = num / 10 % 10;
            num3 = num % 10;

            
            if (num1 == num3)
                Console.WriteLine("Es cap i cua");
            else
                Console.WriteLine("No es cap i cua");





        }
    }
}
