namespace AppDoWhilePromedio
{
    class Program
    {
        static void Main (String [] args)
        {
            int numero, suma=0, contador=0;
            float promedio;

            Console.WriteLine(" Programa el promedio setencia do while ");

            do
            {
                
                Console.WriteLine(" digite numero ");

                numero = int.Parse(Console.ReadLine());
                suma += numero;
                contador += 1;


            } while (numero != 0);
            promedio = suma / (contador-1);

            

            Console.WriteLine(" Promedio: " + promedio);
            Console.ReadKey();
        }
    }
}
