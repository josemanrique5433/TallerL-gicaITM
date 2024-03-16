internal class Program
{
    private static void Main(string[] args)
    {
        String numberString = String.Empty;
        do
        {
            Console.Write("Digite un número entero ó la palabra 'Salir' para salir: ");
            numberString = (Console.ReadLine());
            if (numberString!.ToLower() == "salir")
            {
                continue;
            }


            var numenerInt = 0;
            if (int.TryParse(numberString, out numenerInt))
            {
                if (numenerInt % 2 == 0)
                {

                    Console.WriteLine($" El número {numenerInt} es par");
                }
                else
                {
                    Console.WriteLine($"El número {numenerInt} es impar");
                }

            }
            else
            {
                Console.WriteLine($"Lo que ingresaste: {numberString} no es un número entero");
            }





        } while (numberString!.ToLower() != "salir");

        Console.WriteLine("Game Over");



    }
}