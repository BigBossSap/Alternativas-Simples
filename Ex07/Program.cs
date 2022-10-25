using System;

namespace conversor_cutre
{
    class Program
    {
        static void Main(string[] args)
        {
            double euros, pesetas;
            const double CONVERSOR = 166.386; 
            double resultadoPts, resultadoEur;
            string operacion;


           


            Console.WriteLine("Convertir a euros o pesetas: ");

            operacion = (Console.ReadLine());

           
            if (operacion == "euros")
                {
                Console.WriteLine("Introduce importe: ");
                pesetas = Convert.ToDouble(Console.ReadLine());

                resultadoEur = Math.Round(pesetas / CONVERSOR);
                    Console.WriteLine(resultadoEur);
                }

                else if (operacion == "pesetas")
                {
                Console.WriteLine("Introduce importe: ");
                euros = Convert.ToDouble(Console.ReadLine());
                resultadoPts = Math.Round(euros * CONVERSOR);
                    Console.WriteLine(resultadoPts);
                };
        }
    }
}
