using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Hernan
{
    class Program
    {
        static void Main(string[] args)
        {

            string _eleccion;
            string _password;

            do
            {
                Console.WriteLine("Bienvenidos al Registro. Por Favor elija un Usuario: ");
                _eleccion = Console.ReadLine();
                Console.WriteLine("Ingrese el Password: ");
                _password = Console.ReadLine();

                Users myInfo = new Users(_eleccion, _password);
                myInfo.ChequearDatos();
            } while (_eleccion == "1" && _eleccion == "2");
        }
    }
    
}
