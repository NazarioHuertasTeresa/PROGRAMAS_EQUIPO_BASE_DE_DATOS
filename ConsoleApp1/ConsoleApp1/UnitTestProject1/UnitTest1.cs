using System;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("HOLA, BUENAS TARDES");
            Console.Write("ingresa su edad ");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {

                Console.WriteLine(" REGISTRO EXITOSO USTED ES MAYOR DE EDAD");
            }
            else
            {
                Console.WriteLine("REGISTRO NO EXITOSO, USTED ES MENOR DE EDAD ");
            }
            Console.ReadLine();
        }
        string nombre;
        string correo;
        string tel�fono;
        string ocupaci�n;
        Console.Write("Ingrese su nombre: "); 
        nombre = Console.ReadLine();
        Console.WriteLine(nombre);
        Console.Write("Ingrese su correo: "); 
        correo = Console.ReadLine();
        Console.WriteLine(correo);
        Console.Write("Ingrese su tel�fono: "); 
        tel�fono = Console.ReadLine();
        Console.WriteLine(tel�fono);
        Console.Write("Ingrese su ocupaci�n: "); 
        ocupaci�n = Console.ReadLine();
        Console.WriteLine(ocupaci�n);

    }

}
