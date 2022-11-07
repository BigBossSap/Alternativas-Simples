using System;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fes un programa que a partir d’ una nota numèrica entera entre 0 i 10 indiqui si correspon a:
  [0 .. 4]→suspès
  [5 .. 8]→aprovat
  9→excel.lent
  10→MATRÍCULA D’ HONOR
  altrament: error
  */

            int nota;

            Console.WriteLine("Introduce la nota: ");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 0 && nota<=4)
                Console.WriteLine("Suspenso");
            else if (nota>= 5 && nota<=8)
                Console.WriteLine("Aprovado");
            else if (nota == 9)
                Console.WriteLine("Excelente");
            else if (nota == 10)
                Console.WriteLine("Excelente");
            else
                Console.WriteLine("Nota introducida incorrecta");



        }
    }
}
