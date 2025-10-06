using System;
class Persona

{     
    // campo de cada objeto Persona que almacena  su nombre
    public string Nombre;
    //Campo de cada objeto Persona que almacena su edad
    public int Edad;

    //Campo de cada objeto Persona que almacena su NIF
    public string NIF;

    void Cumpleaños()   //Incrementa en uno la edad del objeto Persona
    {
        Edad++;
    }
    //constructor de persona
    public Persona(string nombre, int edad,string nif)
    {
        Nombre = nombre;
        Edad = edad;
        NIF = nif;
    }
    
     
}


class Trabajador : Persona
{
    //campo de cada objeto Trabajador que almacena cuánto gana
    public int Sueldo;
    
    public Trabajador(string nombre, int edad, string nif, int sueldo) : base(nombre, edad,nif)
    {
        //Inicializamos cada trabajador en base al constructor de Persona
        Sueldo = sueldo;
    }
    
}

class Program
{
    public static void Main()
    {
    Trabajador p = new Trabajador("Josan", 22, "77588260-Z", 100000);
    Console.WriteLine("Nombre=" + p.Nombre);
    Console.WriteLine("Edad=" + p.Edad);
    Console.WriteLine("NIF=" + p.NIF);
    Console.WriteLine("Sueldo=" + p.Sueldo);
    Console.ReadKey();
    }

}
