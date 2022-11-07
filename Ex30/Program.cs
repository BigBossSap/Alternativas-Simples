using System;

namespace Ex30
{
    class Program
    {
        static void Main(string[] args)
        {
            /*30. Fes un programa que donada una data, digui a quina estació de l’any correspon:
Període Estació
21/03 – 20/06 Primavera
21/06 – 20/09 Estiu
21/09 – 20/12 Tardor
21/12 – 20/03 Hivern*/

            int dia, mes;

            Console.WriteLine("dia: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("mes: ");
            mes = Convert.ToInt32(Console.ReadLine());


            if (mes==3 && dia>=21 || mes == 4 || mes == 5 || mes == 6 && dia < 20)
                Console.WriteLine("Primavera");
            else if (mes==6 && dia >= 21 || mes == 7 || mes==8 || mes==9 && dia < 20)
                Console.WriteLine("Estiu");

            else if (mes == 9 && dia >= 21 || mes == 10 || mes == 11 || mes == 12 && dia < 20)
                Console.WriteLine("Tardor");
            else
                Console.WriteLine("Hivern");
        }
    }
}
