using System;
using System.Collections.Generic;
using System.IO;
using System.Management.Instrumentation;
using System.Reflection;

namespace Registration_Hernan
{
    public static class FileHelper
    {
        // Proprieties
        private static int _userId;
        private static string _file;


        public static void DRecords(int user, string file)
        {
            string[] readTxtFile = File.ReadAllLines(file);
            Console.WriteLine("Index   |   Text");
            ForLoop(readTxtFile);
            
        }

        public static void DRemove(int user, string file)
        {
            string txt = "TextFile1.txt";
            
            var readTxtFile = File.ReadAllLines(file);
            var newList = new List<string>(readTxtFile);
            Console.WriteLine("Index   |   Text");
            ForLoop(readTxtFile);
            Console.Write("Choose # Index to delete: ");
            var index = int.Parse(Console.ReadLine());
            newList.RemoveAt(index);
            File.WriteAllLines(txt, newList);
            
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