using System;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fes un programa que demani un angle en graus (0-360) i ens indiqui a quin quadrant es
 troba. Controla que l’angle que s’introdueixi sigui vàlid. Suposarem [0,90) és el 1rQ,
 [90,180) és el 2nQ, [180,270) és el 3rQ i [270,360) és el 4tQ.*/


            int angulo;

            Console.WriteLine("Introduce en angulo 0 - 360: ");
            angulo = Convert.ToInt32(Console.ReadLine());

            if (angulo < 0 || angulo > 360)
                Console.WriteLine("Error");
            else if (angulo > 0 && angulo<90)
                Console.WriteLine("1rQ");
            else if (angulo >= 90 && angulo<180)
                Console.WriteLine("2nQ");
            else if (angulo>=180 && angulo<270)
                Console.WriteLine("3rQ");
            else
                Console.WriteLine("4tQ");




        }
    }
}
