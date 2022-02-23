namespace AppDoWhileValores
{
    class Program
    {
        static void Main(String[] args)
        {
            int numero, suma = 0, contador = 0;

            Console.WriteLine("programa valores acumulados");
            do
            {
                Console.WriteLine("Digite valor: ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 9999)
                {
                    suma += numero;
                }
               
                contador += 1;
            }
            while (numero != 9999);
            if (suma == 0)
            {
                Console.WriteLine(" La suma es igual : " + suma);
            }
            else if (suma <= 0)
            {
                Console.WriteLine(" la suma es menor que 0:" + suma);
            }
            else
            {
                Console.WriteLine(" la suma es mayor que 0: " + suma);
            }

            Console.ReadKey();
        }
    }
}
