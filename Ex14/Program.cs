using System;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fes un programa que digui si un any és de traspàs o no.Ho serà quan sigui múltiple de 4,
com el 2020.Compte, els múltiples de 100 no són tots de traspàs, només aquells que són
múltiples de 400 com el 2000(1900 no va ser de traspàs).*/

            /*multiple de 400 es de traspas
            si multiple de 100 no es de traspaso
            finalment si es multiple de 4 es de traspas*/


            double year;

            Console.WriteLine("Introduce un año: ");
            year = Convert.ToDouble(Console.ReadLine());

            if (year % 400 == 0)
                Console.WriteLine($"{year} es un año de traspaso");
            else if (year % 100 == 0)
                Console.WriteLine($"{year} no es un año de traspaso");
            else if (year % 4==0)
                Console.WriteLine($"{year} es un año de traspaso");
            else
                Console.WriteLine($"{year} no es un año de traspaso");


            // if (year%400==0 !! year%100!=0 && year%4==0)0
        


        }
    }
}
