
using System;

namespace Laboratorio91
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el precio del producto (Ingresar números positivos): ");
            decimal precio = decimal.Parse(Console.ReadLine());

            if (precio <= 0)
            {
                Console.WriteLine("El precio debe ser positivo.");
                return;
            }

            Console.Write("Forma de pago (efectivo/tarjeta): ");
            string formaPago = Console.ReadLine().ToLower();

            if (formaPago == "tarjeta")
            {
                Console.Write("Ingrese el número de cuenta (solo 16 dígitos): ");
                string cuenta = Console.ReadLine();

                if (cuenta.Length == 16 && long.TryParse(cuenta, out _))
                {
                    Console.WriteLine($"Pago realizado con tarjeta. Cuenta: {cuenta}");
                }
                else
                {
                    Console.WriteLine("Número de cuenta inválido.");
                }
            }
            else if (formaPago == "efectivo")
            {
                Console.WriteLine("Pago realizado en efectivo.");
            }
            else
            {
                Console.WriteLine("Forma de pago inválida.");
            }
        }
    }
}
