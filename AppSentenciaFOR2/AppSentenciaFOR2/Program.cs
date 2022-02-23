int limite, numero=0, mayores = 0, menores = 0;

Console.WriteLine("Programas sentencia FOR");
Console.WriteLine("Digite limite de numeros: ");
limite = int.Parse(Console.ReadLine());

for ( int contador= 0; contador < limite; contador++)
{
    Console.WriteLine(" digite numero: ");
    numero = int.Parse(Console.ReadLine());
    if (numero >=1000)
    {
        mayores += 1;
    }
    else
    {
        menores += 1;
    }

}
Console.WriteLine(" los numeros mayores son : " + mayores);
Console.WriteLine(" los numeros menores son : " + menores);
Console.ReadKey();
