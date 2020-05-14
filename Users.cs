using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Hernan
{
    class Users
    {
        private static int _userId;
        private static string _path;
        
        
        public static int Userid
        {
            set
            {
                if(false)
                {
                    Console.WriteLine("Wrong User");
                }

                _userId = value;
            }

            get
            {
                return _userId;
            }
        }
        
        public static string Path
        {
            set
            {
                switch (value)
                {
                    case "1":
                        _path = "TextFile1.txt";
                        break;
                    case "2":
                        _path = "TextFile2.txt";
                        break;
                    default:
                        Console.WriteLine("Wrong File Chosen");
                        break;
                }
            }
            get
            {
                return _path;
            }
        }

        public static void ChequearDatos(int u)
        {


            if (u == 1 || u == 2) 
            {
                Console.WriteLine("Estoy Chequeando Datos");
                var myCurrentInfo = new Information();
                myCurrentInfo.DisplayInformation(Userid);
            }
            else
            {
                Console.WriteLine("Eligio un usuario inexistente, saliendo del programa ");
                
                
            }
        }
    }
}
