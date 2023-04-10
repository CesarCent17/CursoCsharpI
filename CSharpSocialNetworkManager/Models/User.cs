using System;
using CSharpSocialNetworkManager.Utilities;

namespace CSharpSocialNetworkManager.Models
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; } 

        public bool IsActive { get; set; } = true;

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public short Age { get; set; }
        public User(string name, string email, short age) 
        {
            this.Name = name;
            this.Email = email;
            this.Age = age;
            //this.IsActive = true;
            //this.DateCreated = DateTime.Now;
        }

        public void GetInfo()
        {
            Console.WriteLine("\nInformacion del usuario");
            Console.WriteLine($"Nombre: {this.Name}\n Correo: {this.Email}\n Edad: {this.Age}\n Activo: {this.IsActive}\n Fecha: {this.DateCreated.ToString("dd, MM,  yyyy")}");
        }

        public bool IsValid(bool validateAge = true)
        {
            if(string.IsNullOrEmpty(this.Name) || string.IsNullOrEmpty(this.Email) || !HelperValidator.IsValidEmail(this.Email)) return false;
            if((this.Age < 0 || this.Age > 250) && validateAge) return false;
            return true;
        }
    }
}
