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
        private readonly int _UserID;
        private int _TotalRecords;
        private string _OptionDatos;

        public Information(int user)
        {
            this._UserID = user;
        }
        public int UserID
        {
            get => _UserID;
        }


        public int TotalRecords
        {
            get => _TotalRecords;
        }

        public void DisplayInformation()
        {
            // Cuenta las lineas que tiene el archivo y las almacena en una variable
            _TotalRecords = 0;

            Console.WriteLine("User's ID: {0}", _UserID);

            if (File.Exists(ChooseFile(_UserID)))
            {
                using (TextReader reader = File.OpenText(ChooseFile(_UserID)))
                {
                    while (reader.ReadLine() != null) ;
                }
            }
            else 
            { 
                _TotalRecords = 0;
            }

            Console.WriteLine("Total Records: {0}", _TotalRecords);
            Console.WriteLine("[A]dd new Data | [R]emove Data | [D]isplay Records | [Q]uit");
            _OptionDatos = Console.ReadLine().ToLower();
            // Pasa la opcion elegida (Add or Remove) al metodo AddRemove
            AddRemove(_OptionDatos);
             
        }

        // Agrega datos al archivo file
        private void Add()
        {
            // Llama al meotodo ChooseFile y le pasa como parametro el Usuario que eligio para saber que archivo usar. 
            ChooseFile(_UserID);
            FileStream fs = new FileStream(ChooseFile(_UserID), FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            byte[] bdata = Encoding.Default.GetBytes("This is a Test" + Environment.NewLine);
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();

        }

        private void Remove()
        {

            string txt = "TextFile1.txt";
            
            string[] readTxtFile = File.ReadAllLines(ChooseFile(_UserID));
            List<string> newList = new List<string>(readTxtFile);
            Console.WriteLine("Index   |   Text");
            for (int i = 0; i < readTxtFile.Length; i++)
            {
                Console.WriteLine($"{i}         {readTxtFile[i]}");
            }
            Console.Write("Choose # Index to delete: ");
            var index = int.Parse(Console.ReadLine());
            newList.RemoveAt(index);
            string[] newArray = new string[newList.Count];
            File.WriteAllLines(txt, newList);
        }

        private void DisplayRecords(int a)
            {
            string[] readTxtFile = File.ReadAllLines(ChooseFile(_UserID));
            Console.WriteLine("Index   |   Text");
            for (int i = 0; i < readTxtFile.Length; i++)
            {
                Console.WriteLine($"{i}         {readTxtFile[i]}");
            }
            Console.ReadLine();
            Console.Clear();

            }


        public static string ChooseFile(int number)
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

        public void AddRemove(string Opcion)
        {

            switch (Opcion)
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
                    DisplayRecords(_UserID);
                    break;
                case "q":
                    Console.WriteLine("Quiting");
                    break;
                default:

                    break;

                    
            }
            
            

        }

    }
}
