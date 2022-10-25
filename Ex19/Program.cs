using System;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fes un programa que donades dues notes amb decimals (0-10), corresponents a pràctiques
(30%) i a teoria (70%), calculi la mitjana i expressi el resultat en lletres, tenint en compte la
següent taula, i que si una nota qualsevol és inferior a 3 ja no fa mitjana (suspèn
automàticament):
[0 .. 5) ...... suspès
[5 .. 7) ...... aprovat
[7 .. 9) ...... notable
[9 .. 10) ... excel.lent
10 ............. matrícula d’honor*/


            double notaTeoria, notaPractica;
            double notaFinal;

            Console.WriteLine("Nota practica: ");
            notaPractica = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota teoria: ");
            notaTeoria = Convert.ToDouble(Console.ReadLine());

            notaFinal = (notaPractica * 0.30 + notaTeoria * 0.70);

            if (notaPractica < 3 || notaTeoria < 3)
                Console.WriteLine("Suspenso, no llega al 3 en alguna de las partes");
            else 
            
            {

                if (notaFinal >= 0 && notaFinal < 5)
                    Console.WriteLine($"Suspenso Nota Final : {notaFinal}");
                else if (notaFinal >= 5 && notaFinal < 7)
                    Console.WriteLine($"Aprovat Nota Final : {notaFinal}");

                else if (notaFinal < 9)
                    Console.WriteLine($"Notable Nota Final : {notaFinal}");
                else if (notaFinal < 10)
                    Console.WriteLine($"Excelente Nota Final : {notaFinal}");
                else if (notaFinal == 10)
                    Console.WriteLine($"Matrícula de Honor Nota Final : {notaFinal}");
                else
                    Console.WriteLine("Nota incorrecta.");

            }
            
            
            








        }
    }
}
