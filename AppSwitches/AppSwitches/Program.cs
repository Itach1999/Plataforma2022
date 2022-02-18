namespace Switches
{
    class Program
    {
        static void Main (String[] args)
        {
            int numero;
            Console.WriteLine("Ingrese el número: ");
            numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Número uno");
                    break;
                case 2:
                    Console.WriteLine("Número dos");
                    break;
                case 3:
                    Console.WriteLine("Número tres");
                    break;
                case 4:
                    Console.WriteLine("Número cuatro");
                    break;
                case 5:
                    Console.WriteLine("Número cinco");
                    break;
                default:
                    Console.WriteLine("Fuera de rango");
                    break;
            }
            Console.ReadKey();
        }
    }
}
