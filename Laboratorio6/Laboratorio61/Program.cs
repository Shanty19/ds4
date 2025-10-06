using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Ingrese el número deseado:");

        try
        {
            num = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("No ha introducido un dígito válido.");
            num = -1;
        }

        Console.WriteLine($"Número ingresado: {num}");
    }
}
