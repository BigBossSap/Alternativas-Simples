using System;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Fes un programa que passi una lletra a majúscules. Si no és minúscula no ha de fer res.*/

            char letra, letraModificada;

            Console.WriteLine("Introduce una letra:");
            letra = Convert.ToChar(Console.ReadLine());

            if (letra >= 'a' && letra <= 'z')
            {
                letraModificada = (char)(letra - 32);
                Console.WriteLine($"La letra {letra} minuscula pasa a mayuscula como {letraModificada}");

            }

            else if (letra >= 'A' && letra <= 'Z')
            {
                
                Console.WriteLine($"La letra {letra} no es minuscula");

            }

            else
                Console.WriteLine("No es una letra");
        }
    }
}
