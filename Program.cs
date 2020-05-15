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
                
                Console.WriteLine("Welcome to the Registry System. Please Choose an User: ");
                eleccion = Console.ReadLine();
                Console.WriteLine("Please type in your Password: ");
                password = Console.ReadLine();
                Users.Userid = Convert.ToInt32(eleccion);
                Users.Path = eleccion;
                Users.ChequearDatos(Users.Userid);
                


            } while ((eleccion != "1") && (eleccion != "2"));
           
        }
    }
    
}
