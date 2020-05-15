using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
            var win = new Window ("Hello") {
                X = 69,
                Y = 1,
                Width = 50,
                Height = 13,
                
            };
            var winBottomLeft = new Window ("2nd Win") {
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

            var password = new TextField ("") {
                X = 10 ,
                Y = 2,
                Width = 5,
                Height = 1,
                
                
                
            };
            
            prueba.Add(password);
            
            
            var buttonAccept = new Button(10,19,"Ok");
            
            GuiClass myGui = new GuiClass();
            // Envia una accion al boton
            buttonAccept.Clicked = () => password.Text = myGui.Test(password.ToString() ) ;
            prueba.Add(buttonAccept);

            // Add both menu and win in a single call
            Application.Top.Add ( menu, prueba, win, winBottomLeft);
            Application.Run ();





            /*do
            {
                
                Console.WriteLine("Welcome to the Registry System. Please Choose an User: ");
                eleccion = Console.ReadLine();
                Console.WriteLine("Please type in your Password: ");
                password = Console.ReadLine();
                Users.Userid = Convert.ToInt32(eleccion);
                Users.Path = eleccion;
                Users.ChequearDatos(Users.Userid);
                


            } while ((eleccion != "1") && (eleccion != "2"));*/


        }
    }
    
}
