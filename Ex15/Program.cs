// See https://aka.ms/new-console-template for more information


//DV

double segundos, segundosRestantes, segundosRestantes2; 
    
double horas, minutos;


//Valor

Console.WriteLine("Introduce los segundos: ");
segundos = Convert.ToInt32(Console.ReadLine());

//Algoritmos

horas =   Convert.ToInt32(segundos / (60 * 60));

segundosRestantes = segundos % (60 * 60);

minutos = Convert.ToInt32(segundosRestantes / 60);

segundosRestantes2 = Convert.ToInt32(segundos % 60);

Console.WriteLine(horas + " horas " + minutos + " minutos " + segundosRestantes2 + " segundos ");

