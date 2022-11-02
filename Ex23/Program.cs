using System;

namespace Ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*23. Fes un programa que donat un nombre de 2 xifres (té 2 xifres), digui si és cap-i-cua*/

            int num, num1,num2;
            
            Console.WriteLine("Introduce un numero de 2 cifras: ");
            num = Convert.ToInt32(Console.ReadLine());
            num1 = num / 10;
            num2 = num % 10;
            if (num1 == num2)
                Console.WriteLine("Es cap i cua");
            else
                Console.WriteLine("No es cap i cua");

        }
    }
}
