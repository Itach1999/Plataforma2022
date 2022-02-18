namespace SwitchNum
{
    class Program
    {
        static void Main (string[] args)
        {
            string numero;
            Console.WriteLine("Ingrese un número en texto:");
            numero = Console.ReadLine();
            switch (numero. ToUpper())
            {
                case "Uno":
                    Console.WriteLine("1");
                    break;
                case "Dos":
                    Console.WriteLine("2");
                    break;
                case "Tres":
                    Console.WriteLine("3");
                    break;
                case "Cuatro":
                    Console.WriteLine("4");
                    break;
                case "Cinco":
                    Console.WriteLine("5");
                    break;
            }
            Console.ReadLine();
        }
    }
}