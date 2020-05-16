using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using NStack;
using Terminal.Gui;
using Terminal.Gui.Elmish;

namespace Registration_Hernan

{
    public class GuiClass
    {
        private static string _userId;
        
        public ustring UserCheck(string user, string pass)
        {
            if ((user == "1" && pass == "123") || (user == "2" && pass == "3030"))
            {
                Path = user;
                MessageBox.Query(55, 8, ("Welcome User #",user.ToString()).ToString(), 
                    ("Your DB File is:"+ Path + "\n Last Time you Logged in", DateTime.UtcNow ).ToString(), 
                    "Ok");
                return user;
            }
            else
            {
                
                return "Wrong User";
                

            }
        }
        
        private static string _path;
        
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
                        Console.WriteLine("File Doesn't Exist");
                        break;
                }
            }
            get
            {
                return _path;
            }
        }
    }
    
    
}