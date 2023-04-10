using System;
using System.Linq;
using CSharpSocialNetworkManager.Models;
using CSharpSocialNetworkManager.Utilities.Log;

namespace CsharpSocialNetworkManager
{
    class Program
    {
        static void Main(string[] args) 
        {
            var app = new AppManager(new LogJson());
            Console.WriteLine("Redes Sociales Disponibles");

            while (true)
            {
                foreach (var item in app.SocialNetworks.Concat(app.SocialNetworkWithGroups))
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("\nEliga una red social");
                string socialNetworkName = Console.ReadLine();

                var socialNetworkSelected = app.SocialNetworks.FirstOrDefault(p => p.Name.ToLower() == socialNetworkName.ToLower());
                Console.Write(app.GetSocialNetworkInformation(socialNetworkSelected));


                var socialNetworkWithGroupsSelected = app.SocialNetworkWithGroups.FirstOrDefault(p => p.Name.ToLower() == socialNetworkName.ToLower());
                Console.Write(app.GetSocialNetworkInformation(socialNetworkWithGroupsSelected));

                if (socialNetworkSelected == null && socialNetworkWithGroupsSelected == null)
                {
                    Console.WriteLine("Error, no existe tal red social");
                    break;
                };

                Console.WriteLine("1. Crear Usuario\n 2. Ver estadisticas de la red social");
                var opcionSelected = int.Parse(Console.ReadLine());

                switch (opcionSelected)
                {
                    case 1:
                        Console.WriteLine("Por favor ingrese su Nombre");
                        string name = Console.ReadLine();
                        Console.WriteLine("Por favor ingrese su Correo");
                        string email = Console.ReadLine();
                        Console.WriteLine("Por favor ingrese su Edad");
                        short age = short.Parse(Console.ReadLine());
                        var user = new User(name, email, age);
                        string mensaje = user.IsValid() ? "Usuario Valido" : "Usuario Invalido";
                        //if (mensaje == "Usuario Valido") user.GetInfo();
                        //else Console.WriteLine(mensaje);

                        if(socialNetworkSelected != null)
                        {
                            int indexElement = app.SocialNetworks.IndexOf(socialNetworkSelected);
                            app.SocialNetworks[indexElement].Users.Add(user);
                        }

                        if (socialNetworkWithGroupsSelected != null)
                        {
                            int indexElement = app.SocialNetworkWithGroups.IndexOf(socialNetworkWithGroupsSelected);
                            app.SocialNetworkWithGroups[indexElement].Users.Add(user);
                        }
                        //if (socialNetworkSelected != null) socialNetworkSelected.Users.Add(user);
                        //if (socialNetworkWithGroupsSelected != null) socialNetworkWithGroupsSelected.Users.Add(user);
                        break;

                    case 2:
                        if (socialNetworkSelected != null) Console.WriteLine(app.GetSocialNetworkStats(socialNetworkSelected));
                        if (socialNetworkWithGroupsSelected != null) Console.WriteLine(app.GetSocialNetworkStats(socialNetworkWithGroupsSelected));
                        break;


                    default:
                        break;
                }

                

                //return;
            }
        }
    }
}