namespace AppSentencial
{
    class program
    {
        static void Main (String [] args)
        {
            float nota;
            int cont2 = 0, cont3 = 0;

            Console.WriteLine(" Programa sentencia For");

            for ( int cont1 = 1; cont1 <= 10; cont1++)
            {
                Console.WriteLine(" digite nota 1: " + cont1 + ":");
                nota = float.Parse(Console.ReadLine());

                if (nota<=3 || nota >= 3)
                {
                    cont2++;
                }
                else
                {
                    cont3++;
                }

            }
            Console.WriteLine(" la nota mayores o  iguales a 3 son: " + cont2);
            Console.WriteLine(" las notas menores a 3 son :" + cont3);
            Console.ReadKey();
        }
    }
}
