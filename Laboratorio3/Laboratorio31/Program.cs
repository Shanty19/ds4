using System;

namespace OperacionConsola
{
    public class Calculos
    {
        public int Calcular(int num1, int num2)
        {
            // Devuelve directamente el resultado
            return (num1 + num2) * (num1 - num2);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            int num1, num2, respuesta;

            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Crear objeto de la clase Calculos y llamar al método
            Calculos calc = new Calculos();
            respuesta = calc.Calcular(num1, num2);

            Console.WriteLine("El resultado es: " + respuesta);
        }
    }
}
