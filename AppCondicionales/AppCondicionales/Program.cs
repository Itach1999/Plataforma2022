namespace SentenciaIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un número de 1 o 2 dígitos: ");
            numero = int.Parse(Console.ReadLine());
            if (numero < 10)
            {
                Console.WriteLine("El número ingresado es de un sólo dígito");
            }
            else if(numero<=99)
            {
                Console.WriteLine("El número ingresado es de dos dígitos");
            }
            else
            {
                Console.WriteLine("El número tiene más de dos dígitos, error.");
            }
        }
    }
}
