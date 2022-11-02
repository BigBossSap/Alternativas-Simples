using System;

namespace Ex21.b
{
    class Program
    {
        static void Main(string[] args)
        {
            int hhmmss, horas, minutos, segundos;

            Console.WriteLine("Introduce hora/segundos/minutos: XXXXXX ");
            hhmmss = Convert.ToInt32(Console.ReadLine());

            if (hhmmss < 999999)
            {

                horas = hhmmss / 10000;
                minutos = hhmmss / 100 % 100; //hmmss%10000/100
                segundos = hhmmss % 100;

                segundos++;

                if (segundos > 59)
                {
                    minutos++;
                    segundos = 0;
                }
                if (minutos > 59)
                {
                    horas++;
                    minutos = 0;


                }
                if (horas > 23)
                    horas = horas % 24;

                Console.WriteLine($"Son las {horas} horas, {minutos} minutos, {segundos} segundos!");
            }

            else
                Console.WriteLine("numero incorrecto");



        }
    }
}
