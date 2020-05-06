using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Hernan
{
    class Information
    {
        private readonly int _userId;
        private int _totalRecords;
        private string _optionDatos;

        public Information(int user)
        {
            this._userId = user;
        }
        public int UserId
        {
            get => _userId;
        }


        public int TotalRecords
        {
            get => _totalRecords;
        }

        public void DisplayInformation()
        {
            // Cuenta las lineas que tiene el archivo y las almacena en una variable
            _totalRecords = 0;

            Console.WriteLine("User's ID: {0}", _userId);

            if (File.Exists(ChooseFile(_userId)))
            {
                using (TextReader reader = File.OpenText(ChooseFile(_userId)))
                {
                    
                }
            }
            else 
            { 
                _totalRecords = 0;
            }

            Console.WriteLine("Total Records: {0}", _totalRecords);
            Console.WriteLine("[A]dd new Data | [R]emove Data | [D]isplay Records | [Q]uit");
            _optionDatos = Console.ReadLine().ToLower();
            // Pasa la opcion elegida (Add or Remove) al metodo AddRemove
            AddRemove(_optionDatos);
             
        }

        // Agrega datos al archivo file
        private void Add()
        {
            // Llama al metodo ChooseFile y le pasa como parametro el Usuario que eligio para saber que archivo usar. 
            ChooseFile(_userId);
            FileStream fs = new FileStream(ChooseFile(_userId), FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            byte[] bdata = Encoding.Default.GetBytes("This is a Test" + Environment.NewLine);
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();
            DisplayRecords(_userId);

        }

        private void Remove()
        {

            string txt = "TextFile1.txt";
            
            string[] readTxtFile = File.ReadAllLines(ChooseFile(_userId));
            List<string> newList = new List<string>(readTxtFile);
            Console.WriteLine("Index   |   Text");
            for (int i = 0; i < readTxtFile.Length; i++)
            {
                Console.WriteLine($"{i}         {readTxtFile[i]}");
            }
            Console.Write("Choose # Index to delete: ");
            var index = int.Parse(Console.ReadLine());
            newList.RemoveAt(index);
            File.WriteAllLines(txt, newList);
        }

        private void DisplayRecords(int a)
            {
            string[] readTxtFile = File.ReadAllLines(ChooseFile(_userId));
            Console.WriteLine("Index   |   Text");
            for (int i = 0; i < readTxtFile.Length; i++)
            {
                Console.WriteLine($"{i}         {readTxtFile[i]}");
            }
            Console.ReadLine();
            Console.Clear();

            }


        private static string ChooseFile(int number)
        {
            switch(number)
            {
                case 1:
                    return "TextFile1.txt";
                case 2:
                    return "TextFile2.txt";
                default:
                    break;
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
