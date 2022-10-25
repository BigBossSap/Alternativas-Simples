using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 10. Fes un programa que demani una lletra i digui si és majúscula, minúscula o no és lletra*/

            char caracter;

            Console.WriteLine("Escribe un caracter: ");
            caracter = Convert.ToChar(Console.ReadLine());

            if(caracter >=  'a' && caracter <= 'z')
                Console.WriteLine( "Minuscula");
            else if (caracter >= 'A' && caracter <= 'Z')
                Console.WriteLine("Mayusucula");
            else
                Console.WriteLine("No es una letra");






        }
    }
}
