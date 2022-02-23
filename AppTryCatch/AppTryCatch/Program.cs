// See https://aka.ms/new-console-template for more information
int numero;
float division;
Console.WriteLine("Programa Manejo de Errores");
Console.WriteLine("Digite numero:");
numero = int.Parse(Console.ReadLine());

try
{

    division = numero / 0;
}
catch (Exception ex)
{
    Console.WriteLine("El error es:" + ex.Message);
}
