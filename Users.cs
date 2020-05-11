using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Hernan
{
    class Users
    {
        public Users(int user, string password)
        {
            this.Password = password;
            this.User = user;
        }

        private int User { get; set; }

        public string Password { get; set; }


        public void ChequearDatos()
        {
            
            if(User == 1 || User == 2)
            {
                Console.WriteLine("Estoy Chequeando Datos");
                var myCurrentInfo = new Information(User);
                myCurrentInfo.DisplayInformation(User);
            }
            else
            {
                Console.WriteLine("Eligio un usuario inexistente, saliendo del programa ");
                
                
            }
        }
    }
}
