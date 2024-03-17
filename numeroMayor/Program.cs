using Shared;
do
{
    var a = ConsolExtension.GetIn("Ingrese el primer número : ");
    var b = ConsolExtension.GetIn("Ingrese el segundo número: ");
    var c = ConsolExtension.GetIn("Ingrese el tercer número : ");

    if (a > b && a > c)
    {
        Console.WriteLine($"El numero mayor es: {a}");
    }
    else if (b > a && b > c)
    {
        Console.WriteLine($"El numero mayor es: {b} ");
    }
    else
    {
        Console.WriteLine($"El número mayor es: {c}");
    }


}while (true);
