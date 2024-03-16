internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero%2 == 0) 
        {

            Console.WriteLine($" El número {numero} es par");
        }else
        { 
            Console.WriteLine($"El número {numero} es impar");
        }

        



    }
}