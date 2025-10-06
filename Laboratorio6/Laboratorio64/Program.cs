using System;

class Program
{
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Acceso negado - no cumple con el criterio de edad");
        }
        else
        {
            Console.WriteLine("Acceso concedido - cumple con el criterio de edad");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            CheckAge(15); // prueba con edad 15
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
