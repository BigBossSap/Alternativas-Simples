using System;

namespace Ex31
{
    class Program
    {
        static void Main(string[] args)
        {
            /*31. (Dificultat ++) Fes un programa per validar una data. L’entrada de la data serà un número
   enter en format ddmmaaaa i cal controlar
    Que el mes estigui entre 1 i 12
    Que el dia sigui correcte per al mes corresponent (incloent el mes de febrer i els
   anys de traspàs)*/

            int data, mes, dia, any;

            Console.WriteLine("Introduce la fecha: ddmmaaaa");
            data = Convert.ToInt32(Console.ReadLine());

            mes = data / 10000 % 100;
            dia = data / 1000000;
            any = data % 10000;
            bool anytraspas = any % 400 == 0 || any % 100 != 0 && any % 4 == 0;

            if (dia < 1 || dia >31 || mes <1 || mes>12)
                Console.WriteLine("Ko");
            else if (dia > 30 && (mes == 4 ||mes==6|| mes == 9 || mes == 11))
                Console.WriteLine("Ko");
            else if ( dia > 29 && mes ==2)
                Console.WriteLine("Ko");
            else if (dia > 28 && mes==2 && !anytraspas)
                Console.WriteLine("Ko");

            else
            Console.WriteLine("ok");
                   

            
           









        }
    }
}
