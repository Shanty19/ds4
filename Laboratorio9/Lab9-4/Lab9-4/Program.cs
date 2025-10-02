using System;

namespace Laboratorio94
{
    public class Aleatorios
    {
        private Random rnd;

        public Aleatorios()
        {
            rnd = new Random();
        }

        public int GenerarNumero(int min, int max)
        {
            if (min > max) throw new ArgumentException("min no puede ser mayor que max");
            return rnd.Next(min, max + 1);       // El Next upper bound es exclusivo, por eso +1
        }

        public int[] GenerarArreglo(int cantidad, int min, int max)
        {
            if (cantidad <= 0) throw new ArgumentException("cantidad debe ser > 0");
            int[] arreglo = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = GenerarNumero(min, max);
            }
            return arreglo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ale = new Aleatorios();

            Console.WriteLine("Ejemplo: Generar un número entre 1 y 10:");
            Console.WriteLine(ale.GenerarNumero(1, 10));

            Console.WriteLine("\nEjemplo: Generar arreglo de 5 números entre 1 y 20:");
            int[] arr = ale.GenerarArreglo(5, 1, 20);
            Console.WriteLine(string.Join(", ", arr));

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}


