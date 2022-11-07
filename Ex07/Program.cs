using System;

namespace conversor_cutre
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7. Fes un programa que passi d’euros a pessetes i/o al revés. Ens ha de demanar quina operació
volem fer i l’import pertinent. Cal aplicar el canvi que toqui (1€ = 166’386 ptes)
*/

            int pessetes;
            double euros;
            const double CANVI = 166.386;
            string operacio = "";

            
            Console.WriteLine("Escriu eurosCanvi per passar a euros i pessetesCanvi per passar a pessetes");
            operacio = Console.ReadLine();

            if (operacio == "eurosCanvi")
            {
                Console.WriteLine("Quantes pessetes vols canviar a euros");
                pessetes = Convert.ToInt32(Console.ReadLine());
                euros = Math.Round(pessetes / CANVI, 2);
                Console.WriteLine($"El canvi de {pessetes} pessetes es {euros} euros");
            }
            else if (operacio == "pessetesCanvi")
            {
                Console.WriteLine("Quants euros vols canviar a pessetes");
                euros = Convert.ToDouble(Console.ReadLine());
                pessetes = (int)(euros * CANVI);
                Console.WriteLine($"El canvi de {euros} euros es {pessetes} pessetes");
            }
            else
                Console.WriteLine("NO SAPS ESCRIURE");
        }
    }
}
