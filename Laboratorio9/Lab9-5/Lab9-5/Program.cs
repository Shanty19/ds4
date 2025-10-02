using System;
using System.Collections.Generic;

namespace Laboratorio95
{
    class Program
    {
        static void Main(string[] args)
        {
            Aleatorios ale = new Aleatorios();

            Console.Write("Ingrese cantidad de números a generar: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese valor mínimo: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Ingrese valor máximo: ");
            int max = int.Parse(Console.ReadLine());

            if (cantidad > (max - min + 1))
            {
                Console.WriteLine("No se pueden generar tantos números únicos en ese rango.");
                return;
            }

            HashSet<int> numeros = new HashSet<int>();
            while (numeros.Count < cantidad)
            {
                numeros.Add(ale.GenerarNumero(min, max));
            }

            Console.WriteLine("Números generados (no repetidos):");
            foreach (var num in numeros)
            {
                Console.Write(num + " ");
            }
        }
    }

    class Aleatorios
    {
        private Random rnd = new Random();

        public int GenerarNumero(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }
    }
}

