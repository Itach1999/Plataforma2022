namespace SentenciaIF
{
    class Program
    {
        static void Main (string[] args)
        {
            int num1, num2, suma, resta;
            float producto, division;
            Console.WriteLine("Ingrese el número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                suma = num1 + num2;
                Console.WriteLine("La suma de los dos números es: " + suma);
                resta = num1 - num2;
                Console.WriteLine("La resta de los dos números es: " + resta);
            }
            else
            {
                producto = num1 * num2;
                Console.WriteLine("El producto de los dos números es: " + producto);
                division = num1 / num2;
                Console.WriteLine("La división de los dos números es: " + division);
            }
        }
    }
}
