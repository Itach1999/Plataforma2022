namespace AppFabrica
{
    class Program
    {
        static void Main (string[] args)
        {
            int piezas, aptas=0, contador;
            float longitud;
            Console.WriteLine("Ingrese el número de piezas: ");
            piezas = int.Parse(Console.ReadLine());
            contador = 0;
            while (contador<piezas)
            {
                Console.WriteLine("Ingrese la longitud: ");
                longitud = float.Parse(Console.ReadLine());
                if (longitud >= 1.2 && longitud <= 1.3)
                {
                    aptas += 1;
                }
                contador++;
            }
            Console.WriteLine("Las piezas son aptas: " + aptas);
            Console.ReadKey();
        }
    }
}
