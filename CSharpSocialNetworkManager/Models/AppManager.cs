using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CSharpSocialNetworkManager.Utilities.Log;

namespace CSharpSocialNetworkManager.Models
{
    class AppManager
    {
        public string AppTitle { get; set; }
        public ILog<string> Log { get; set; }
        public List<SocialNetwork> SocialNetworks { get; set; }
        public List<SocialNetworkWithGroups> SocialNetworkWithGroups { get; set; }

        public AppManager(ILog<string> log)
        {
            this.Log = log;
            this.AppTitle = "Administrador de redes sociales";
            this.SocialNetworks = new List<SocialNetwork>();
            this.SocialNetworkWithGroups = new List<SocialNetworkWithGroups>();
            this.SocialNetworks = new List<SocialNetwork>();
            this.InicializeSocialNetworks();
        }

        public void InicializeSocialNetworks()
        {
            SocialNetworkWithGroups.Add(new SocialNetworkWithGroups("Facebook", "Meet with people")
            {
                Users = new List<User>(),
                Groups = new List<string>() { "Premier League", "FIFA 23", "C#"},
                DateCreated = new DateTime(2008, 01, 25)
            });

            SocialNetworks.Add(new SocialNetwork("Instagram", "Meet with people")
            {
                Users = new List<User>(),
                DateCreated = new DateTime(2010, 05, 01)
            });
            this.Log.SaveLog("InicializeSocialNetworks");
        }

        public string GetSocialNetworkInformation<T>(T socialNetwork)
        {
            if (socialNetwork == null) return "";
            var socialNetworkItem = socialNetwork as SocialNetwork;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("\nInformacion de la red social");
            stringBuilder.AppendLine($"Nombre: {socialNetworkItem.Name}");
            stringBuilder.AppendLine($"Descripcion: {socialNetworkItem.Description}");
            stringBuilder.AppendLine($"Fecha: {socialNetworkItem.DateCreated.ToString("dd/MM/yyyy")}");
            if (socialNetworkItem is SocialNetworkWithGroups)
            {
            var socialNetworkWithGroupsItem = socialNetwork as SocialNetworkWithGroups;

                stringBuilder.AppendLine($"Grupos: {string.Join(",",socialNetworkWithGroupsItem.Groups)}");

            }
            this.Log.SaveLog("GetSocialNetworkInformation");
            return stringBuilder.ToString();
        }

        public string GetSocialNetworkStats<T>(T socialNetwork)
        {
            if (socialNetwork == null) return "";
            var socialNetworkItem = socialNetwork as SocialNetwork;
            StringBuilder stringBuilder = new StringBuilder();


            try
            {
                stringBuilder.AppendLine("\nEstadistica de la red social");
                stringBuilder.AppendLine($"Cantidad de usuarios: {socialNetworkItem.Users.Count}");
                stringBuilder.AppendLine($"Promedio de edad: {socialNetworkItem.Users.Average(p => p.Age)}");
                stringBuilder.AppendLine($"El usuario de mayor edad tiene: {socialNetworkItem.Users.Max(p => p.Age)}");
                stringBuilder.AppendLine($"El usuario de menor edad tiene: {socialNetworkItem.Users.Min(p => p.Age)}");

                if (socialNetworkItem is SocialNetworkWithGroups)
                {
                    var socialNetworkWithGroupsItem = socialNetwork as SocialNetworkWithGroups;

                    stringBuilder.AppendLine($"Cantidad de grupos: {socialNetworkWithGroupsItem.Groups.Count}");

                }
            }
            catch (Exception ex)
            {

                this.Log.SaveLog(ex.Message); ;
            }

            this.Log.SaveLog("GetSocialNetworkStats");
            return stringBuilder.ToString();
        }
    }
}
