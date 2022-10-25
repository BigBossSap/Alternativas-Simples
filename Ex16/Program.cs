using System;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fes un programa que demani tres números introduïts per teclat o digui si estan ordenats. (dos
 nombres entrats consecutivament iguals considerarem que no trenquen l’ordre)*/

            double num1, num2, num3;


            Console.WriteLine("Introduce el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el tercer numero: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 <= num2 && num2 <= num3 || num1>= num2 && num2>=num3)
                Console.WriteLine($"{num1}, {num2} y {num3} estan ordenados");
            else
                Console.WriteLine($"{num1}, {num2} y {num3} no estan ordenados");




        }
    }
}
