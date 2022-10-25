using System;

namespace ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fes un programa que demani tres números introduïts per teclat i end digui quin és el més
gran.*/


            double  num1, num2, num3;

            Console.WriteLine("Numero 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Numero 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Numero 3: ");
            num3 = Convert.ToDouble(Console.ReadLine());


            if (num1 < num2)
                num1 = num2;
            if (num1 < num3)
                num1 = num3;

            Console.WriteLine(num1);

                    
        }
    }
}
