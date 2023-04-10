using System;

namespace CsharpExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            string numeroString = Console.ReadLine();
            try
            {
                int numero = int.Parse(numeroString);
                Console.WriteLine($"has escrito el numero: {numero}");
            }
            catch (FormatException fx)
            {
                Console.WriteLine("Caracter invalido");

                //region Condicional
                #if DEBUG
                Console.WriteLine(fx.Message);
                Console.WriteLine(fx.StackTrace);
                #endif

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error");
                //throw;
            }
            
        }
    }
}
