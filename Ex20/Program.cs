using System;

namespace Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Volem calcular el preu d’una entrada de cinema:
   Sabem que una entrada estàndard val 5 €.
   Si tens carnet jove et fan un 15% de descompte.
   Els dimarts fan un 20%.
   El cap de setmana no fan cap descompte a ningú.
   Només et poden fer un descompte.
   Fes un programa que demani per cada opció si es cumpleix o no (resposta s/n) i ens digui el
   preu que hem de pagar. (escull l’ordre de preguntes correcte) */

            char carnetJove; //s/n
            int dia; //0-6
            const  double preuEntrada = 5;
            double PreuFinal;

            Console.WriteLine("Escriu el dia de la setmana: ");
            dia = Convert.ToInt32(Console.ReadLine());

            if (dia < 0 || dia > 6)
                Console.WriteLine("Dia Erroneo");
            else if (dia > 4)
                Console.WriteLine("Precio entrada son 5 euros");
            else if (dia == 1)
                Console.WriteLine($"El precio es {5*0.80} euros");
            else{
                Console.WriteLine("Tienes Carnet Jove? s/n");
                carnetJove = Convert.ToChar(Console.ReadLine());
                if (carnetJove == 's')
                    Console.WriteLine($"El precio de la entrada es {5*0.85}");
                else if (carnetJove == 'n')
                    Console.WriteLine($"El precio de la entrada es 5 euros");
                else
                    Console.WriteLine("ERROR");

                

            }


            










        }
    }
}
