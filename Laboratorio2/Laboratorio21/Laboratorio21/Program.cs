using System;
namespace Laboratorio2
{

    class Program
    {
        static void Main(string[] args)
        {
            Client cliente = new Client();
            cliente.FirstName = "Su_Nombre";
            cliente.FirstName = "Su_Apellido";
            cliente.Age = 15;
            cliente.Id = 1;
            Console.WriteLine(cliente.GetFullname());
        }
    }
    public class Client
    {
        //Declaramos las variables de instancia en clase.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullname()
        {
            //Utilizando variables de instancia dentro de metodos de la clase 
            return FirstName + " " + LastName;
        }
    }
}