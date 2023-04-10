using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSocialNetworkManager.Models
{
    class SocialNetworkWithGroups : SocialNetwork
    {
        public List<string> Groups { get; set; }

        public SocialNetworkWithGroups(string name, string email) :base(name, email) 
        {

        }
    }
}
