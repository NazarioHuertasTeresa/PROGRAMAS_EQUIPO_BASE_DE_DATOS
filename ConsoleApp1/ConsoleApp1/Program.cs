using System;

namespace ConsoleApp1
{
    class program
    {
        static void Main(string[] args)
        {
            string nombre;
            string correo;
            string teléfono;
            string ocupación;


            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine(nombre);

            Console.Write("Ingrese su correo: ");
            correo = Console.ReadLine();
            Console.WriteLine(correo);

            Console.Write("Ingrese su teléfono: ");
            teléfono = Console.ReadLine();
            Console.WriteLine(teléfono);

            Console.Write("Ingrese su ocupación: ");
            ocupación = Console.ReadLine();
            Console.WriteLine(ocupación);
        }
    }
}



