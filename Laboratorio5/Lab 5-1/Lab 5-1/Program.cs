
//Tiara Rodriguez 8-1002-2396
class PruebaVector1
{
    private int[] sueldos;
    static void Main(string[] args)    // main principal
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.Cargar();
        pv.Imprimir();
    }
    public void Cargar()
    {
        sueldos = new int[6];          //Se incializa el vector con 5
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("Ingrese sueldo del operario " + f + ": ");
            String linea;
            linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea); // SSe le asigna  asigna los 5 sueldos al vector
        }
    }
    //Muestra los sueldos de los operarios en el vector sueldos[f]
    public void Imprimir()
    {
        Console.Write("Los 5 sueldos de los operarios \n");
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("[" + sueldos[f] + "] ");
        }
        Console.ReadKey();
    }

}