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

        public Information(string user)
        {
            this._UserID = user;
        }
        public string UserID
        {
            get => _UserID;
            set => _UserID = value;
        }


        public int TotalRecords
        {
            get => _TotalRecords;
        }

        public void DisplayInformation()
        {
            var lineCount = File.ReadAllLines("TextFile1.txt").Count();

            Console.WriteLine("Informacion de Usuario: {0}", _UserID);
            Console.WriteLine("Total de Records es: {0}", lineCount);

            PrivateInformation(_UserID);

             
        }

        public void PrivateInformation(string ChooseUser)
        {
            
            FileStream fs = new FileStream("TextFile1.txt", FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("Esto es una prueba" + Environment.NewLine);
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();

            

        }

    }
}
