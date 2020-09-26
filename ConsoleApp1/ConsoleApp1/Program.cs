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

    }
}
