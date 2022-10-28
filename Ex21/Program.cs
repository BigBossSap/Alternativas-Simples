using System;

namespace Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fes un programa que donada una hora, minut i segon, incrementi un segon i mostri l’hora
resultant.Cal verificar que l’hora estigui entre 0 i 23, els minuts entre 0 i 59 i els segons
entre 0 i 59.*/

            int hora, minutos, segundos;


            Console.WriteLine("Hora: ");
            hora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minutos: ");
            minutos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundos: ");
            segundos = Convert.ToInt32(Console.ReadLine());

            if (hora >= 0 && hora <= 23 && minutos >= 0 && minutos <= 59 && segundos >= 0 && segundos <= 59) 
            { 
                segundos++;

            if (segundos == 60)
                    
                {
                    minutos++;
                segundos = 0;
                    Console.WriteLine($"La hora final es {hora} horas, {minutos} minutos , {segundos} segundos");

                }
                if (minutos == 60)
                {
                    minutos = 0;
                    hora++;
                    if (hora == 24)
                        hora = 0;
                    
                    Console.WriteLine($"La hora final es {hora} horas, {minutos} minutos , {segundos} segundos");
                }

            }
        }
    }
}
