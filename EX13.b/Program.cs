using System;

namespace EX13.b
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fes un programa que passi una lletra a majúscules i viceversa*/

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
                letraModificada = (char)(letra + 32);
                Console.WriteLine($"La letra {letra} mayuscula pasa  a minuscula como {letraModificada}");

            }

            else
                Console.WriteLine("No es una letra");
        }
    }
}
