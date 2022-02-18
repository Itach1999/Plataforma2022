namespace AppWhileNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 0;
            Console.WriteLine("Ingrese un número positivo: ");
            numero = Math.Abs(int.Parse(Console.ReadLine()));
            while (contador < numero)
            {
                contador++;
                Console.WriteLine("Los números son: " + contador);
            }
            Console.ReadKey();
        }
    }
}
