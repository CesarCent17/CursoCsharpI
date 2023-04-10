using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSocialNetworkManager.Models
{
    class SocialNetwork
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<User> Users { get; set; }

        public DateTime DateCreated { get; set; }

        public SocialNetwork(string name, string description) 
        { 
            this.Name = name;
            this.Description = description;
        }
    }
}
