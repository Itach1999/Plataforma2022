namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma;
            decimal promedio, decimales;
            Console.WriteLine("Programa suma y promedio: ");
            Console.WriteLine("Ingrese número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 3: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 4: ");
            num4 = int.Parse(Console.ReadLine());
            suma = num1 + num2 + num3 + num4;
            Console.WriteLine("La suma es: " + suma);
            promedio = suma / 4;
            decimales = decimal.Round(promedio, 2);
            Console.WriteLine("El promedio de la suma es: " + decimales);
        }
    }
}
