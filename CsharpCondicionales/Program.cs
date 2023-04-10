using System;

namespace CsharpCondicionales
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Digite su edad");
            var edadUsuarioString = Console.ReadLine();
            string mensaje = int.TryParse(edadUsuarioString, out int edadUsuario) && edadUsuario>=0 ? "Calculando edad":"Edad invalida";
            Console.WriteLine(mensaje);

            //operador ternario c#
            if (mensaje == "Edad invalida") return; 

            if (edadUsuario >= 18) Console.WriteLine($"Usted es mayor de edad tiene {edadUsuario} anios");
            else if (edadUsuario < 18 && edadUsuario >= 15) Console.WriteLine($"Usted es adolescente tiene {edadUsuario} anios");
            else Console.WriteLine("Es menor de edad");



        }
    }
}