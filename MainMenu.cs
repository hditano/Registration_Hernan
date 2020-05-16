using System;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using NStack;
using Terminal.Gui.Elmish;
using Terminal.Gui;

namespace Registration_Hernan
{
    class MainMenu
    {
        public string DTotalRecords(string id)
        {
            switch (id)
            {
                case "1":
                {
                    int count = 0;
                    var totalRecords = File.ReadAllLines("TextFile1.txt");

                    for (var i = 0; i < totalRecords.Length; i++)
                    {
                        count++;
                    }
                    
                    return Convert.ToString(count);
                }
                case "2":
                {
                    int count = 0;
                    var totalRecords = File.ReadAllLines("TextFile2.txt");

                    for (var i = 0; i < totalRecords.Length; i++)
                    {
                        count++;
                    }

                    return Convert.ToString(count);
                }
                default:
                    return "";
            }
        }

    }
}

