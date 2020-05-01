using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            var lineCount = File.ReadAllLines("TextFile1.txt").Count();

            Console.WriteLine("Informacion de Usuario: {0}", _UserID);
            Console.WriteLine("Total de Records es: {0}", lineCount);
            Console.WriteLine("Quiere [A]gregar datos | [B]orrar datos | [Q]uit");
            _OptionDatos = Console.ReadLine().ToLower();
            // Pasa la opcion elegida (Add or Remove) al metodo AddRemove
            AddRemove(_OptionDatos);


            //PrivateInformation(_UserID);

             
        }

        // Agrega datos al archivo file
        public void Add(int ChooseUser)
        {

            const string userFile1 = "TextFile1.txt";
            const string userFile2 = "TextFile2.txt";
            string fileChoosen = "";

            if (ChooseUser == 1)
                { fileChoosen = userFile1; }
            else if (ChooseUser == 2)
                { fileChoosen = userFile2; }
            // else
                // TODO ERROR HANDLER
            

            FileStream fs = new FileStream(fileChoosen, FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("Esto es una prueba" + Environment.NewLine);
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();

            

        }

        // Remueve datos del archivo file
        public void Remove(int ChooseUser)
        {

        }


        public void AddRemove(string Opcion)
        {

            switch (Opcion)
            {
                case "a":
                    Console.WriteLine("Agregando Datos");
                    Add(_UserID);
                    break;

                case "b":
                    Console.WriteLine("Borrando Datos");
                    Remove(_UserID);
                    break;
                case "q":
                    Console.WriteLine("Saliendo del Programa");
                    break;
                default:
                    break;
            }
            
            

        }

    }
}
