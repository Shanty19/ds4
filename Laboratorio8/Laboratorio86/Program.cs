class ClaseBase
{
    public virtual void masTests()
    {
        Console.WriteLine("Método en ClaseBase");
    }
}

class ClaseHijo : ClaseBase
{
    public override void masTests()
    {
        Console.WriteLine("Método sobrescrito en ClaseHijo");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Corrio la aplicación");
    }
}