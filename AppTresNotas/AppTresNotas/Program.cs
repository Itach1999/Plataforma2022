namespace TresNotas
{
    class Program
    {
        static void Main (string[] args)
        {
            float nota1, nota2, nota3, suma, promedio;
            Console.WriteLine("Ingrese la primera nota");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota");
            nota3 = float.Parse(Console.ReadLine());
            suma = nota1 + nota2 + nota3;
            promedio = suma / 3;
            if (promedio == 3) {
                Console.WriteLine("Usted está promocionado");
                Console.WriteLine("Su promedio es: " + promedio);
            } else if (promedio > 3.9 && promedio <= 4.9) {
                Console.WriteLine("Su promedio es bueno");
                Console.WriteLine("Su promedio es: " + promedio);
            } else if (promedio >= 5.0) {
                Console.WriteLine("Su promedio es excelente");
                Console.WriteLine("Su promedio es : " + promedio);
            }
            else
            {
                Console.WriteLine("Usted no está promocionado");
                Console.WriteLine("Su promedio es: " + promedio);
            }
        }
    }
}
