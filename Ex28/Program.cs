using System;

namespace Ex28
{
    class Program
    {
        static void Main(string[] args)
        {
            /*28. Fes un programa que ens demani el número de DNI i ens calculi la lletra del NIF. Per
   calcular-la simplement dividim el número per 23 i segons el residu escollim la lletra */


            int dni;
            int modul;
            string lletraDni = "TRWAGMYFPDXBNJZSQVHLCKE";
            Console.WriteLine("Introduce tu numero de DNI:");
            dni = Convert.ToInt32(Console.ReadLine());

            modul = dni % 23;

            Console.WriteLine(lletraDni[modul]);







        }
    }
}
