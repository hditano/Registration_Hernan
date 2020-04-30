using System;
using System.Collections.Generic;
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
        }

        public int TotalRecords
        {
            get => _TotalRecords;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Informacion de Usuario: {0}", _UserID);
            Console.WriteLine("Total de Records es: 1000");
        }

    }
}
