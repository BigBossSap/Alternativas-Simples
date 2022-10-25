using System;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Calcula el valor absolut d’ún número. El valor absolut de 3 és 3. De -3 és 3. (sempre positiu)*/

            int num,result;

            Console.WriteLine("Introduce tu numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0) {

                result = num * -1;

                Console.WriteLine($"El valor abosulto de {num} es {result}");
                    }

            else {
                result = num;
                Console.WriteLine($"El valor absoulto de {num} es {result}");
                    }
                
                






        }
    }
}
