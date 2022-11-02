using System;

namespace Ex27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 27. Fes un programa que demani un número (1-7) i escrigui a quin dia de la setmana correspon
(dilluns-diumenge). En cas de no entrar una dada correcta, mostra un error*/

            int num;

            Console.WriteLine("Introduce un número del 1 al 7: ");
            num= Convert.ToInt32(Console.ReadLine());
           
            if (num == 1)
                Console.WriteLine("Lunes");
            else if (num == 2)
                Console.WriteLine("Martes");
            else if (num == 3)
                Console.WriteLine("Miercoles");
            else if (num == 4)
                Console.WriteLine("Jueves");
            else if (num == 5)
                Console.WriteLine("Viernes");
            else if (num == 6)
                Console.WriteLine("Sábado");
            else if (num == 7)
                Console.WriteLine("Domingo");
            
            if (num<1 || num>7)
                Console.WriteLine("Número incorrecto!");


        }
    }
}
