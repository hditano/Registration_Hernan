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


            

             
        }

        // Agrega datos al archivo file
        private void Add()
        {
            // Llama al meotodo ChooseFile y le pasa como parametro el Usuario que eligio para saber que archivo usar. 
            ChooseFile(_UserID);
            FileStream fs = new FileStream(ChooseFile(_UserID), FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("Esto es una prueba" + Environment.NewLine);
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();

        }

        private void Remove()
        {
            File.Delete(ChooseFile(_UserID));

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
                    Console.WriteLine("Agregando Datos");
                    Add();
                    break;

                case "b":
                    Console.WriteLine("Borrando Datos");
                    Remove();
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
