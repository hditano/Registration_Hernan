using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
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

        public string UserCheck(string user, string pass)
        {
            switch (user)
            {
                case "1" when pass == "123":
                    MessageBox.Query(55, 8, ("Welcome User #", user.ToString()).ToString(),
                        ("Your DB File is:" + Path + "\n Last Time you Logged in", DateTime.UtcNow).ToString(),
                        "Ok");
                    return user;
                case "2" when pass == "3030":
                    MessageBox.Query(55, 8, ("Welcome User #", user.ToString()).ToString(),
                        ("Your DB File is:" + Path + "\n Last Time you Logged in", DateTime.UtcNow).ToString(),
                        "Ok");
                    return user;
                default:
                    MessageBox.ErrorQuery(55, 8, "Error", "Wrong User", "Ok");
                    return "";
            }
        }

        public string DisplayInformationCheck(string user, string pass)
        {
            switch (user)
            {
                case "1" when pass == "123":
                    return user;
                case "2" when pass == "3030":
                    return user;
                default:
                    return "";
                
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
                        _path = value;
                        break;
                    case "2":
                        _path = "TextFile2.txt";
                        _path = value;
                        break;
                    default:
                        Console.WriteLine("File Doesn't Exist");
                        break;
                }

            }
            get { return _path; }
        }


    }
}
    
    