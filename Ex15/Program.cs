using System;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*15. Fes un programa que demani dos números qualssevol i després els mostri en ordre creixent.
   Demana a i b, i escriu a i b. Ha de permutar el valor de les variables si cal.
   */
            int num1, num2, aux;
            Console.WriteLine("num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                aux = num1;
                num1 = num2;
                num2 = aux;

                Console.WriteLine($"Nuevo valor: {num1}, {num2}");
            }

            else
                Console.WriteLine($"Nuevo valor: {num1}, {num2}");





            

            

        }
    }
}
