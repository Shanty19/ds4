internal class program
{
    private static void Main(string[] args)
    {
        int n, x;
        string linea;
        Console.Write("Ingrese un numero entero positivo: ");
        linea = Console.ReadLine();
        n = int.Parse(linea);
        x = 1;
        while (x <= n)
        {
            Console.WriteLine(x);
            Console.WriteLine(" , ");
            x = x + 1;
        }
        Console.ReadKey();
    }
}