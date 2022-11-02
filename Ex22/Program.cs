using System;

namespace Ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*22. Fes un programa que calculi la tarifa d’un pàrking, sabent que val 1€ la hora o fracció, és a
dir que si estic 3 hores pago 3€, i si estic 3 hores i cinc minuts pago 4€. Per simplificar, per
entrar les dades demana separadament l’hora d’entrada, el minut d’entrada, hora de
sortida i minut de sortida. Suposem que tarifiquem dintre del mateix dia.*/

            int horaEntrada, minutosEntrada, horaSalida, minutoSalida, horaTotal, minutosTotal, precioHora, precioFinal;


            Console.WriteLine("Hora de entrada: ");
            horaEntrada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Minuto de entrada: ");
            minutosEntrada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hora de salida: ");
            horaSalida = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Minuto de salida: ");
            minutoSalida = Convert.ToInt32(Console.ReadLine());



            horaTotal = horaSalida - horaEntrada;
            minutosTotal = minutoSalida - minutosEntrada;


            if (minutosTotal < 0) {
                horaTotal--;
                minutosTotal += 60;
            }

            precioFinal = horaTotal * 1;

            if (minutosTotal > 0)
                precioFinal++;

            Console.WriteLine($"Tu precio final es de {precioFinal}");
            




                
           







        }
    }
}
