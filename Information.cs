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
        private string _UserID;
        private int _TotalRecords;
        private string _OptionDatos;

        public Information(string user)
        {
            this._UserID = user;
        }
        public string UserID
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
            Console.WriteLine("Quiere [A]gregar datos o [B]orrar datos");
            _OptionDatos = Console.ReadLine().ToLower();
            // Pasa la opcion elegida (Add or Remove) al metodo AddRemove
            AddRemove(_OptionDatos);


            //PrivateInformation(_UserID);

             
        }

        // Agrega datos al archivo file
        public void Add(string ChooseUser)
        {
            
            FileStream fs = new FileStream("TextFile1.txt", FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("Esto es una prueba" + Environment.NewLine);
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();

            

        }

        // Remueve datos del archivo file
        public void Remove(string ChooseUser)
        {

        }


        public void AddRemove(string Opcion)
        {

            switch (Opcion)
            {
                case "a":
                    Console.WriteLine("Agregando Datos");
                    break;

                case "b":
                    Console.WriteLine("Borrando Datos");
                    break;

                default:
                    break;
            }
            
            

        }

    }
}
