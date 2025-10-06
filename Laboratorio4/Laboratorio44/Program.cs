class program
{
       static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la nota del estudiante");
        float nota = float.Parse(Console.ReadLine());

        if (nota >= 70)
        {
            Console.WriteLine("El estudiante aprobo la materia");
        }
        else
        {
            Console.WriteLine("El estudiante no aprobo la materia");
        }
    }
}