using System;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Fes un programa que demani una lletra i digui si és o no una vocal.*/

            char letra;

            Console.WriteLine("Introduce una letra: ");
            letra = Convert.ToChar(Console.ReadLine());



            if ((letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u'))
                Console.WriteLine($"{letra} es una vocal");
            else
                Console.WriteLine($"{letra} no es una vocal");

        }
    }
}
