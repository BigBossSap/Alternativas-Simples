// See https://aka.ms/new-console-template for more information
//DV

int hores;
double preuHora, irpf, salarioBruto, retencion, sueldoNeto;


//Valores

Console.WriteLine("Horas trabajadas: ");
hores = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Precio por hora: ");
preuHora = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("% de IRPF: ");
irpf = Convert.ToDouble(Console.ReadLine());

//Algoritmos

salarioBruto = hores * preuHora;

retencion = salarioBruto * irpf / 100;

sueldoNeto = salarioBruto - retencion;

Console.WriteLine("Salario Bruto: " + salarioBruto);
Console.WriteLine("Retención: " + retencion);
Console.WriteLine("Salario Neto: " + sueldoNeto);
