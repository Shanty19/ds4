internal class program
{
    private static void Main(string[] args)
    {
        int fac = 1, n;
        string linea;
        Console.Write("Ingrese un numero entero positivo: ");
        linea = Console.ReadLine();
        n = int.Parse(linea);
        for (int x = 1; x <= n; x++)
        {
            fac = fac * x;
        }
        Console.WriteLine("El factorial es: " + fac);
        Console.ReadKey();
    }
}   