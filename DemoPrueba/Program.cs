using System;
using CursoCsharp.Enumerations;

namespace DemoPrueba
{
    class Program
    {
        static void Main(string[] args)
        {   
            DateTime? fechaTerminacionCurso = null;
            const string nombre = null;
            try
            {
                Console.WriteLine($"Fecha de terminacion del curso: {fechaTerminacionCurso?.Date}");
                Console.WriteLine($"Mi nombre es: {nombre}");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            #region Mascotas
            bool tieneMascota = true;
            Console.WriteLine($"Tengo mascota? {tieneMascota}");
            #endregion

        }
    }
}
