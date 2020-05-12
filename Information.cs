using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Hernan
{
    class Information
    {    
        // Properties
        private readonly int _userId;
        private int _totalRecords;
        private string _optionDatos;

        // Constructor
        public Information(int user)
        {
            this._userId = user;
        }
        

        public void DisplayInformation(int user, string path)
        {
            // Cuenta las lineas que tiene el archivo y las almacena en una variable
           

            Console.WriteLine("User's ID: {0}", user);

            if (File.Exists(ChooseFile(user)))
            {
                using (TextReader reader = File.OpenText(ChooseFile(user)))
                {
                    
                }
                
            }
            else 
            { 
                Console.WriteLine("El Archivo no existe");
            }

            Console.WriteLine("Total Records: {0}", FileHelper.DTotalRecords(user, ChooseFile(user)));
            Console.WriteLine("[A]dd new Data | [R]emove Data | [D]isplay Records | [Q]uit");
            _optionDatos = Console.ReadLine().ToLower();
            // Pasa la opcion elegida (Add or Remove) al metodo AddRemove
            AddRemove(_optionDatos);
             
        }

        // Agrega datos al archivo file
        private void Add()
        {
            // Llama al metodo ChooseFile y le pasa como parametro el Usuario que eligio para saber que archivo usar. 
            FileHelper.DAdd(_userId, ChooseFile(_userId)); 
            FileHelper.DRecords(_userId,(ChooseFile(_userId)));
        }

        private void Remove()
        {
            FileHelper.DRemove(_userId, ChooseFile(_userId));
        }

        private void DisplayRecords(int user)
            {
                FileHelper.DRecords(user, ChooseFile(user));
                Console.ReadLine();

            }


        public static string ChooseFile(int number)
        {
            switch(number)
            {
                case 1:
                    return "TextFile1.txt";
                case 2:
                    return "TextFile2.txt";
            }
            return null;
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
                case "d":
                    Console.WriteLine("Display Record");
                    DisplayRecords(_userId);
                    break;
                case "q":
                    Console.WriteLine("Quiting");
                    break;
            }
            
            

        }

    }
}
