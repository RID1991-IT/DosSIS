using System;
using System.IO;
using System.Collections.Generic;

using static System.Console;

namespace Console
{
    class Program
    {
        static void Main()
        {
            string path, newpath, pathO, newPathDirectory, temp, subpath;
           
            
            
            
            
            
            
            
            
            
            //string slash;
            //List<string> steps = new List<string>();
            ////Реализация перехода по каталогам
            //slash = @"\";
            //pathO = @"E:\";
            //steps.Add(pathO);
            //Consol.Show(pathO);
            //WriteLine("Введите каталог в какой вы хотите перейти");
            //newPathDirectory = ReadLine();
            // = pathO + newPathDirectory + slash;
            //steps.Add(pathO);
            //Consol.Show(pathO);
            /////////////////////////////////////////////////////

            //steps.IndexOf(pathO, 0);
            //newpath =pathO+"hta.txt";
            //WriteLine("Введите название файла");
            //newpath = ReadLine();
            path = @"E:\1\123.doc";
            //subpath  = @"program\avalon";
            //WriteLine("Выберете диск");
            //pathO = ReadLine();
            //Consol.Show(pathO);
            //WriteLine("Введите путь файла");
            //path = ReadLine();

            //newpath = pathO + newpath;
            //Consol.CopyFile(path, newpath);
            //Consol.Del(path);
            //Consol.CreateDirectory(path, subpath);
            Consol.CreateFile(path);
        }
    }
}
