﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Hernan
{
    class Users
    {
        private string _user;
        private string _password;

        public Users(string user, string password)
        {
            this._password = password;
            this._user = user;
        }

        public string User
        {
            get => _user;
            set => _user = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }


        public void ChequearDatos()
        {
            
            if(_user == "1" || _user == "2")
            {
                Console.WriteLine("Estoy en el metodo Chequear Datos");
                Information myCurrentInfo = new Information(_user);
                myCurrentInfo.DisplayInformation();
            }
            else
            {
                Console.WriteLine("Eligio un usuario inexistente, saliendo del programa ");
                
                
            }
        }
    }
}