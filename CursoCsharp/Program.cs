using System;
using CursoCsharp.Enumerations;

namespace CursoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string nombre = "Cesar";
            var apellido = " Centu rion ";
            short edad = 22;
            //double alturaEnMetros = 1.76;
            float alturaEnMetross = float.Parse(1.76.ToString());

            Console.WriteLine(string.Format("Mi nombre tiene {0} letras", nombre.Length));
            Console.WriteLine($"Mi apellido tiene {apellido.Trim().Replace(" ","").Length} letras");
            Console.WriteLine($"Mi edad es {edad} y mi altura es {alturaEnMetross}");

            DateTime fechaNacimiento = new DateTime(2000, 10, 17);
            Console.WriteLine($"Mi fecha de nacimiento es {fechaNacimiento.Date.ToString("dd/MM/yyyy")}");
            var fechaActual = DateTime.Now;
            var diferenciaDeFechas = fechaActual - fechaNacimiento;
            Console.WriteLine($"Mi edad es {diferenciaDeFechas.Days/365}");
            var migenero = Genero.Masculino;
            Console.WriteLine($"Mi genero es {migenero}");

        }
    }
}