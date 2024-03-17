using Shared;

internal class Program
{
    private static void Main(string[] args)
    {
     
        var number = 0;
        do
        {
           number = ConsolExtension.GetIn("Digite un número entero ó 0 para salir: ");
           if (number % 2 == 0)
           {

            Console.WriteLine($" El número {number} es par");
           }
           else
           {
           Console.WriteLine($"El número {number} es impar");
           }         
        } while (number != 0);
        Console.WriteLine("Game Over");

    }
}