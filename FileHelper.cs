using System;
using System.Collections.Generic;
using System.IO;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using Terminal.Gui;
using Terminal.Gui.Elmish;

namespace Registration_Hernan
{
    public static class FileHelper
    {
        // Proprieties


        public static void DRecords(int user, string path)
        {
        
            
            string[] readTxtFile = File.ReadAllLines(Users.Path);
            Console.WriteLine("Index   |   Text");
            ForLoop(readTxtFile);
            var myInfo1 = new Information();
            myInfo1.DisplayInformation(Users.Userid);

        }

        public static void DRemove(int user, string file)
        {
            
            
            var readTxtFile = File.ReadAllLines(Users.Path);
            var newList = new List<string>(readTxtFile);
            Console.WriteLine("Index   |   Text");
            ForLoop(readTxtFile);
            Console.Write("Choose # Index to delete: ");
            var index = int.Parse(Console.ReadLine());
            newList.RemoveAt(index);
            File.WriteAllLines(file, newList);
            var myInfo2 = new Information();
            myInfo2.DisplayInformation(Users.Userid);

        }

        public static void DAdd()
        {
            
            
            Console.WriteLine("Ingrese el Texto a grabar, presione enter al terminar");
            string myText = Console.ReadLine();
            FileStream fs = new FileStream(Users.Path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            byte[] bdata = Encoding.Default.GetBytes(myText + Environment.NewLine);
            fs.Write(bdata, 0, bdata.Length);
            fs.Close(); 
            var myInfo3 = new Information();
            myInfo3.DisplayInformation(Users.Userid);
            
        }

        public static int DTotalRecords()
        {
            int _TotalRecords = 0;
            var totalRecords = File.ReadAllLines(Users.Path);
            
            for (int i = 0; i < totalRecords.Length; i++)
            {
                _TotalRecords++;
            }

            return _TotalRecords;
        }

        private static void ForLoop(string[] fileRead)
        {
            
            for (var i = 0; i < fileRead.Length; i++)
            {
                Console.WriteLine($"{i}         {fileRead[i]}");
            }
        }

    }
}