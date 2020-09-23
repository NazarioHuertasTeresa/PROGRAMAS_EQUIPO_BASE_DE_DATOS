using System;

namespace CONDICIONALES
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese su edad: ");
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
