using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Hernan
{
    class Information
    {    
        // Properties
        private string _optionDatos;
        // Constructor
       

        public void DisplayInformation(int user)
        {
            // Cuenta las lineas que tiene el archivo y las almacena en una variable
           
            

            Console.WriteLine("User's ID: {0}", Users.Userid);

            if (File.Exists(Users.Path))
            {
                using (TextReader reader = File.OpenText(Users.Path))
                {
                    
                }
                
            }
            else 
            { 
                Console.WriteLine("El Archivo no existe");
            }
            

            Console.WriteLine("Total Records: {0}", FileHelper.DTotalRecords());
            Console.WriteLine("[A]dd new Data | [R]emove Data | [D]isplay Records | [C]hange User | [Q]uit");
            _optionDatos = Console.ReadLine().ToLower();
            // Pasa la opcion elegida (Add or Remove) al metodo AddRemove
            AddRemove(_optionDatos);
            
        }

        // Agrega datos al archivo file
        private void Add()
        {

            FileHelper.DAdd(); 
            FileHelper.DRecords(Users.Userid, Users.Path);
        }

        private void Remove()
        {
            FileHelper.DRemove(Users.Userid, Users.Path);
        }
        
        private void ChangeUser()
        {
            Console.WriteLine("Type your UserID: ");
            var newUser = Convert.ToInt32(Console.ReadLine());
            Users myNewUser = new Users();
            DisplayInformation(newUser);
        }

        private void DisplayRecords()
            {
                
                FileHelper.DRecords(Users.Userid, Users.Path);
                

            }



        // Remueve datos del archivo file

        private void AddRemove(string opcion)
        {

            switch (opcion)
            {
                case "a":
                    Console.WriteLine("Add Record");
                    Add();
                    break;
                case "r":
                    Console.WriteLine("Remove Record");
                    Remove();
                    break;
                case "c":
                    Console.WriteLine("Change User");
                    ChangeUser();
                    break;
                case "d":
                    Console.WriteLine("Display Record");
                    DisplayRecords();
                    break;
                case "q":
                    Console.WriteLine("Quiting");
                    break;
            }
            
            

        }

    }
}
