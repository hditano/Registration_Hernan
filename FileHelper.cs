using System;
using System.Collections.Generic;
using System.IO;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;

namespace Registration_Hernan
{
    public static class FileHelper
    {
        // Proprieties


        public static void DRecords(int user, string file)
        {
            string[] readTxtFile = File.ReadAllLines(file);
            Console.WriteLine("Index   |   Text");
            ForLoop(readTxtFile);
            var myInfo1 = new Information(user);
            myInfo1.DisplayInformation(user, file);
            
        }

        public static void DRemove(int user, string file)
        {
            
            
            var readTxtFile = File.ReadAllLines(file);
            var newList = new List<string>(readTxtFile);
            Console.WriteLine("Index   |   Text");
            ForLoop(readTxtFile);
            Console.Write("Choose # Index to delete: ");
            var index = int.Parse(Console.ReadLine());
            newList.RemoveAt(index);
            File.WriteAllLines(file, newList);
            var myInfo2 = new Information(user);
            myInfo2.DisplayInformation(user, file);

        }

        public static void DAdd(int user, string path)
        {
            
            Console.WriteLine("Ingrese el Texto a grabar, presione enter al terminar");
            string myText = Console.ReadLine();
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            byte[] bdata = Encoding.Default.GetBytes(myText + Environment.NewLine);
            fs.Write(bdata, 0, bdata.Length);
            fs.Close(); 
            var myInfo3 = new Information(user);
            myInfo3.DisplayInformation(user, path);
            
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