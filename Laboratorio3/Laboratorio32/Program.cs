using System;

namespace OperacionConsola
{
    public class Calculos
    {
        // Método del primer ejercicio
        public int Calcular(int num1, int num2)
        {
            return (num1 + num2) * (num1 - num2);
        }

        // Método del segundo ejercicio: área de un círculo
        public double CalculoArea(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=== Menú de Cálculos ===");
            Console.WriteLine("1. Operación (a+b)*(a-b)");
            Console.WriteLine("2. Calcular área de un círculo");
            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Calculos calc = new Calculos();

            if (opcion == 1)
            {
                int num1, num2, respuesta;

                Console.Write("Ingrese el primer número: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                respuesta = calc.Calcular(num1, num2);

                Console.WriteLine("El resultado es: " + respuesta);
            }
            else if (opcion == 2)
            {
                double radio;

                Console.Write("Ingrese el radio del círculo: ");
                radio = Convert.ToDouble(Console.ReadLine());

                double area = calc.CalculoArea(radio);

                Console.WriteLine("El área del círculo es: " + area.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}