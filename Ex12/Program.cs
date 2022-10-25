using System;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fes un programa que demani un caràcter i digui si és o no lletra

            char letra;

            Console.WriteLine("Introduce un caracter: ");
            letra = Convert.ToChar(Console.ReadLine());

            if (letra >= 'A' && letra <= 'Z' || letra >= 'a' && letra <= 'z')
                Console.WriteLine($"{letra} es una letra");
            else
                Console.WriteLine($"{letra} no es una letra");



        }
    }
}
