using System;
using System.IO;

namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string buff; ;
            FileStream F = new FileStream("cList.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(F);
            buff = Console.ReadLine();

            sw.WriteLine(buff);
            //this is an edit
            buff = sw.ReadLine();
            Console.Write(buff);
            sw.Close();
            F.Close();
        }
    }
}