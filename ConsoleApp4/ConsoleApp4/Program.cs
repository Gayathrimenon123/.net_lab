using System.IO;
using System;
class program
{
    static void Main(string[] args)
    {
        /* string path = @"H:\TestData";
         Directory.CreateDirectory(path);
         string[] a = Directory.GetDirectories(path);
         for (int i = 0; i < a.Length; i++)
         {
             Console.WriteLine(a[i]);
         }
         string path = @"H:\TestData\file.txt";
         Console.WriteLine(File.Exists(path) ? "file exists" : "file does not exist");*/
     
        string pathName2 = @"H:\TestData\file3.txt";
        Console.WriteLine(File.ReadAllText(pathName2));
    }
}

