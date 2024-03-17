using Shared;

do
{
    Console.WriteLine("Ingrese tres números diferentes...");
    var a = ConsolExtension.GetIn("Ingrese el primer número : ");
    var b = ConsolExtension.GetIn("Ingrese el segundo número: ");
    

    if (a == b)
    {
        Console.WriteLine("Los números deben ser diferentes; vueva a empezar");
        continue;
    }
    var c = ConsolExtension.GetIn("Ingrese el tercer número : ");
    if (b == c || c==a)
    {
        Console.WriteLine("Los números deben ser diferentes; vueva a empezar");
        continue;
    }
    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($" EL número mayor es {a}, el de le medio es {b}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($" EL número mayor es {a}, el de le medio es {c}, el menor es {b}");
        }

    }
    else if (b > a && b > c)
    {
        if (a > c) 
        {
       Console.WriteLine($" EL número mayor es {b}, el de el medio es {a}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($" EL número mayor es {b}, el de el medio es {c}, el menor es {a}");
        }
    }
    else
    {
        if (a > b && b>c)
        {
            Console.WriteLine($" EL número mayor es {c}, el de el medio es {a}, el menor es {b}");
        }
        else
        {
            Console.WriteLine($" EL número mayor es {c}, el de el medio es {b}, el menor es {a}");
        }
    }

} while (true);