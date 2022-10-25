using System;

namespace senar_o_parell
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fes un programa que ens digui si un número és parell o senar. Cal dividir per 2 i mirar el
            residu.Si el residu és 0 el nombre és parell i si el residu és 1 el nombre és senar. */

            int num, residu;
            

            Console.WriteLine("número: ");
            num = Convert.ToInt32(Console.ReadLine());

            residu = num % 2;

            if (residu == 0)
                Console.WriteLine("Parell");
            else
                Console.WriteLine("Senar");



            
            
          
        }
    }
}
