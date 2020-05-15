using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NStack;
using Terminal.Gui;
using Terminal.Gui.Elmish;

namespace Registration_Hernan

{
    public class GuiClass
    {
        public ustring Test(string a)
        {
            if (a == "Prueba")
            {
                return "felicitaciones fue elegido prueba";
            }
            else
            {
                return "No fue elegido prueba";
            }
        }
    }
}