

//Lab9-3

namespace Laboratorio93
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el lado A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado C: ");
            double c = double.Parse(Console.ReadLine());

            // Condición para formar un triángulo
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Es un triángulo equilátero.");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Es un triángulo isósceles.");
                else
                    Console.WriteLine("Es un triángulo escaleno.");
            }
            else
            {
                Console.WriteLine("No se puede formar un triángulo con esos lados.");
            }
        }
    }
}

