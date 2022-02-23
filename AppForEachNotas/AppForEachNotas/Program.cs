namespace AppForEach
{
    class Program
    {
        static void Main (string [] args)
        {
            int limite, mayores = 0, menores = 0;
            float nota;

            Console.WriteLine(" Digite limite de notas: ");
            Console.WriteLine(" Sentencia ForEach Notas");

            limite = int.Parse(Console.ReadLine());

            float[] notas = new float[limite];

            for ( int conta = 1; conta<=limite; conta++)
            {
                Console.WriteLine("Digita nota " + conta + ":");
                nota = float.Parse(Console.ReadLine());
                notas[conta-1] = nota;
            }
            foreach (float nota2 in notas)
            {
                if (nota2 >= 3)
                {
                    mayores += 1;
                }
                else
                {
                    menores += 1;
                }
            }
            Console.WriteLine(" las notas mayores son" + mayores);
            Console.WriteLine(" las notas menores son" + menores);

        }
    }
}
