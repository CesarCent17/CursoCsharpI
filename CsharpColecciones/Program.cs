using System;
using System.Linq;

namespace CsharpColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] listaDeNumeros = new int[5];

            #region Asignacion manual en el array
            //listaDeNumeros[0] = 1;
            //listaDeNumeros[1] = 2;
            //listaDeNumeros[2] = 3;
            //listaDeNumeros[3] = 4;
            //listaDeNumeros[4] = 5;
            #endregion

            #region Array
            //for (int i = 0; i < listaDeNumeros.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero");
            //    string numeroString = Console.ReadLine();
            //    bool esNumero = int.TryParse(numeroString, out int numerosalida);
            //    //_ = numerosalida == 0 ? numerosalida = 1 : listaDeNumeros[i] = numerosalida;
            //    listaDeNumeros[i] = numerosalida;
            //    //Console.WriteLine(numerosalida);
            //    while (esNumero!=true)
            //    {
            //        Console.WriteLine("Error caracter invalido, vuelva a intentar...");
            //        string numeroStringW = Console.ReadLine();
            //        bool esNumeroW = int.TryParse(numeroStringW, out int numerosalidaW);
            //        if (esNumeroW) esNumero = true;
            //        listaDeNumeros[i] = numerosalidaW;
            //    }
            //}
            //Console.WriteLine("\n");
            //foreach (int i in listaDeNumeros)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Diccionarios
            //var listaDeDatos = new Dictionary<string, int>();
            ////int id = 1;
            //string valorDigitado = "";
            //while (valorDigitado != ".")
            //{
            //    Console.WriteLine("Ingrese numero o ingrese . para terminar");
            //    valorDigitado = Console.ReadLine();
            //    if (valorDigitado != "." && int.TryParse(valorDigitado, out int result))
            //    {
            //        string id = Guid.NewGuid().ToString();
            //        listaDeDatos.Add(id, int.Parse(valorDigitado));
            //        Console.WriteLine($"Su id es {id} y su valor es {listaDeDatos[id]}\n");
            //    }
            //}

            //foreach (var item in listaDeDatos)
            //{
            //    Console.WriteLine($"Clave: {item.Key} Valor: {item.Value}");
            //}
            #endregion

            #region Listas
            var listaDePorcentajes = new List<float>();
            listaDePorcentajes.Add(50.51f);
            listaDePorcentajes.Add(30.60f);
            listaDePorcentajes.Add(70.80f);
            listaDePorcentajes.Add(81.15f);


            Console.WriteLine($"Mi lista contiene {listaDePorcentajes.Count} elementos");
            Console.WriteLine($"Mi lista contiene un 81.15? {listaDePorcentajes.Contains(81.15f)}");

            foreach (var item in listaDePorcentajes)
            {
                Console.WriteLine(item);
            }
            #endregion

        }
    }
}