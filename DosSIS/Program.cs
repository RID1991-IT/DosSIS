using System;
using System.IO;
using System.Collections.Generic;

using static System.Console;

namespace DosSIS
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathO, subpath, pathMove, newPathDirectory, command, str, path;
            path = @"D:\DZ.doc";
            //subpath = @"program\avalo4n";
            //pathO = @"E:\1";
            //pathMove = "";
            // Consol.CreateDirectory(pathO, subpath);
            //Реализация перехода по каталогам
            do
            {
                WriteLine("Введите команду");
                str = ReadLine();
                str = str.Trim();
                //int position = str.IndexOf(' ');
                //command = str.Substring(0, position);
                //str = str.Substring(position  +  1);
                //position = str.IndexOf(' ');
                //path = str.Substring(0, position);
                //str = str.Substring(position  +  1);
                switch (str)
                {
                    case "Move":
                        DriveInfo[] drivers = DriveInfo.GetDrives();
                        foreach (var driver in drivers)
                        {
                            if (driver.IsReady)
                            {
                                ForegroundColor = ConsoleColor.DarkGreen;
                                WriteLine($"{driver.Name} ");
                            }

                        }
                        WriteLine("Выберите диск");
                        pathMove = ReadLine() + ":\\";
                        do
                        {
                            Clear();
                            Consol.Show(pathMove);
                            WriteLine("Введите каталог в какой вы хотите перейти");
                            newPathDirectory = ReadLine();
                            pathMove = pathMove + newPathDirectory + @"\";
                        }
                        while (newPathDirectory != "11");
                        break;
                    case "Help":
                        Consol.Help();
                        break;
                    case "openfile":
                        Consol.OpenFile(path);
                        break;
                    case "openfile.exe":
                        Consol.OpenExeFile(path);
                        break;
                }
            } while (str != "End");
            ///////////////////////////////////////////////////

            //steps.IndexOf(pathO, 0);
            //newpath =pathO+"hta.txt";
            //WriteLine("Введите название файла");
            //newpath = ReadLine();
            // path = @"E:\1\123.doc";
            //subpath  = @"program\avalon";
            //WriteLine("Выберете диск");
            //pathO = ReadLine();
            //Consol.Show(pathO);
            //WriteLine("Введите путь файла");
            //path = ReadLine();

            //newpath = pathO + newpath;
            //Consol.CopyFile(path, newpath);
            //Consol.Del(path);
            ///Consol.CreateFile(path);  
        }
    }
}
