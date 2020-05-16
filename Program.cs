using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data.OleDb;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NStack;
using Terminal.Gui;
using Terminal.Gui.Elmish;

namespace Registration_Hernan
{
    static class Program
    {
        static void Main()
        {

            Application.Init ();
            var menu = new MenuBar (new MenuBarItem [] {
                new MenuBarItem ("_File", new MenuItem [] {
                    new MenuItem ("_Quit", "", () => { 
                        Application.RequestStop (); 
                    })
                }),
            });
            
            var prueba = new Window ("Prueba") {
                X = 0,
                Y = 1,
                Width = 69,
                Height = Dim.Fill(),
            };
            var win = new Window ("Display Information") {
                X = 69,
                Y = 1,
                Width = 50,
                Height = 13,
                
            };
            var winBottomLeft = new Window ("Database Content") {
                X = 69,
                Y = 14,
                Width = 50,
                Height = 15,
            };
            
            
            var labelUser = new Label ("Username: ") {
                X = 1,
                Y = 1,
                Width = 20,
                Height = 1
            };
            prueba.Add (labelUser);

            var username = new TextField ("") {
                X = 10,
                Y = 1,
                Width = 3,
                Height = 1
            };
            prueba.Add (username);

            var labelPass = new Label ("Password: ") {
                X = 1,
                Y = 2,
                Width = 20,
                Height = 1
            };
            prueba.Add (labelPass);

            var password = new TextField ("") 
            {
                Secret = true,
                X = 10 ,
                Y = 2,
                Width = 5,
                Height = 1,
            };
            prueba.Add(password);
            
            var buttonAccept = new Button("Ok")
            {
                X = 10,
                Y = 19
            };
            prueba.Add(buttonAccept);
            

            // Display Information Controls


            var UserNumber = new Label("Welcome User #:")
                {
                    X = 6,
                    Y = 1,
                    Width = 20,
                    Height = 1
                };
            win.Add(UserNumber);
            
                var userLabel = new Label("")
                {
                    X = 20,
                    Y = 1
                };
            win.Add(userLabel);
                
                // Envia una accion al boton
                
            
            
            // Database Content Controls
            var dbTotalRecords = new Label("Total Records: ")
            {
                X = 6,
                Y = 4,
                Width = 20,
                Height = 1
            };
            win.Add(dbTotalRecords);
            
            var dbLabelRecords = new Label("Prueba")
            {
                X = 20,
                Y = 4,

            };
            win.Add(dbLabelRecords);
            
            ListView myList =  new ListView(new Rect(1, 1, 16, 4), new string[]
            {
                "Prueba una",
                "Prueba dos",
                "Prueba tres"
            });
            winBottomLeft.Add( myList);
            
            MainMenu myTotalRecords = new MainMenu();
            GuiClass myGui = new GuiClass();
            buttonAccept.Clicked = () =>
            {
                userLabel.Text = (myGui.UserCheck(username.Text.ToString(), password.Text.ToString()));
                dbLabelRecords.Text = myTotalRecords.DTotalRecords(username.Text.ToString());
            };



                Application.Top.Add(win,prueba,  winBottomLeft);
            Application.Run();
        }
        
    }
    
}
