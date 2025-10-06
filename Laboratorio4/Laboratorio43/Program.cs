internal class program 
{
    private static void Main(string[] args)
    {
        int suma, cant, valor, promedio;
        string linea;
        suma = 0;
        cant = 0;   
        do
        {
            Console.Write("Ingrese un numero entero positivo (0 para terminar): ");
            linea = Console.ReadLine();
            valor = int.Parse(linea);
            if (valor != 0)
            {
                suma = suma + valor;
                cant = cant + 1;
            }
        } while (valor != 0);
        if (cant == 0)
            Console.WriteLine("No se ingresaron numeros");
        else
        {
            promedio = suma / cant;
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}