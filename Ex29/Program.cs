using System;

namespace Ex29
{
    class Program
    {
        static void Main(string[] args)
        {
            /*29. Fes un programa que demani un número de 2 xifres màxim i l’escrigui en nombres romans.
    Per exemple el 49 s’escriu ajuntant el 40 i el 9: XLIX. */

            int num, desenes, unitats;

            Console.Write("Introduce un numero de 2 cifras como máximo: ");
            num = Convert.ToInt32(Console.ReadLine());

           

            if (num < 1 || num > 99)
                Console.WriteLine("Numero incorrecto");
            else
            {
                desenes = num / 10;
                unitats = num % 10;


                if (desenes == 1)
                    Console.Write("X");
                else if (desenes == 2)
                    Console.Write("XX");
                else if (desenes == 3)
                    Console.Write("XXX");
                else if (desenes == 4)
                    Console.Write("XL");
                else if (desenes == 5)
                    Console.Write("L");
                else if (desenes == 6)
                    Console.Write("LX");
                else if (desenes == 7)
                    Console.Write("LXX");
                else if (desenes == 8)
                    Console.Write("LXXX");
                else if (desenes == 9)
                    Console.Write("XC");
              

                if (unitats == 1)
                    Console.WriteLine("I");
                else if (unitats == 2)
                    Console.WriteLine("II");
                else if (unitats == 3)
                    Console.WriteLine("III");
                else if (unitats == 4)
                    Console.WriteLine("IV");
                else if (unitats == 5)
                    Console.WriteLine("V");
                else if (unitats == 6)
                    Console.WriteLine("VI");
                else if (unitats == 7)
                    Console.WriteLine("VII");
                else if (unitats == 8)
                    Console.WriteLine("VIII");
                else if (unitats == 9)
                    Console.WriteLine("IX");


            }

        }



        }
    }

