namespace AppForEach
{
    class Program
    {
        static void Main (string [] args)
        {
            int[] sueldos = new int[5];

            Console.WriteLine(" Programa sentencia ForEach");
            
            for ( int contador=0; contador < 5; contador++)
            {
                Console.WriteLine(" Digite Sueldo:");
                sueldos[contador] = int.Parse(Console.ReadLine());

            }

            for (int contador = 0; contador < 5; contador++)
            {
                Console.WriteLine(sueldos[contador]);
                

            }
            foreach ( int sueldo in sueldos)
            
            {
                Console.WriteLine(sueldo);
            }

            Console.WriteLine(sueldos[4]);
        }
    }
}
