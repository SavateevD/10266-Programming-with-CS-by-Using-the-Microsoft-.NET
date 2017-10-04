using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Files
{
    class Program
    {
        public const string fileName1 = @"..\..\test.txt";
        public const string dirName1 = @"..\..\..\";

        static void ShowDirTree(String dirName)
        {
            ShowDirTree(new DirectoryInfo(dirName));
        }

        static void ShowDirTree(DirectoryInfo dir, int margin = 0)
        {
            DirectoryInfo[] dirs = dir.GetDirectories();
            String m = new String(' ', margin);
            foreach (DirectoryInfo d in dirs)
            {
                Console.Write(m);
                Console.WriteLine(d.Name.ToUpper());
                ShowDirTree(d, margin + 4);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.Write(m);
                Console.WriteLine(file.Name.ToLower());
            }
        }
        
        static void Main(string[] args)
        {

            if (!File.Exists(fileName1))
                File.Create(fileName1);

            FileInfo fi = new FileInfo(fileName1);

            Console.WriteLine("{0} : {1}", fi.FullName,
                fi.LastWriteTime);

            DirectoryInfo di = new DirectoryInfo(dirName1);

            Console.WriteLine(di.FullName);

            ShowDirTree(di.FullName);

            /*
            DirectoryInfo[] dirs = di.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
                Console.WriteLine(dir.Name.ToUpper());

            FileInfo[] files = di.GetFiles();
            foreach(FileInfo file in files)
                Console.WriteLine(file.Name.ToLower());
            */

            string[] lines = { "Строка 1", "Строка 2", "Строка 3" };

            File.WriteAllLines(fileName1, lines);
            File.AppendAllText(fileName1, "Последняя строчка");

            using (FileStream fs = new FileStream(fileName1, FileMode.Open))
            {
                StreamReader reader = new StreamReader(fs, true);

                int lineCounter = 0, charCounter = 0, wordCounter = 0;

                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                    lineCounter++;
                    //string[] strings = s.Split(' ');
                    wordCounter += s.Split(' ').Length;
                    charCounter += s.Length;
                }

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Lines : {0} Words : {1} Chars : {2}",
                    lineCounter, wordCounter, charCounter);
            }
            //reader.Close();


            
        }
    }
}
