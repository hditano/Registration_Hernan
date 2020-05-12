using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Hernan
{
    static class Program
    {
        static void Main(string[] args)
        {
            string eleccion;
            string password;

            do
            {
                Console.WriteLine("Bienvenidos al Registro. Por Favor elija un Usuario: ");
                eleccion = Console.ReadLine();
                Console.WriteLine("Ingrese el Password: ");
                password = Console.ReadLine() ;
                Users myInfo = new Users(Convert.ToInt32(eleccion), password);
                myInfo.ChequearDatos();
                

            } while ((eleccion != "1") && (eleccion != "2"));
           
        }
    }
    
}
