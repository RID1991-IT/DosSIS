
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;

namespace DosSIS
{
    class Consol
    {
        public static void CopyFile(string path, string newPath)//копирование файла
        {
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                File.Copy(path, newPath, true);
            }

        }
        public static void DelFile(string path) // Удаление файла
        {
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                File.Delete(path);
            }
        }

        public static string Show(string dirName)//показ каталогов и файлов
        {
            if (Directory.Exists(dirName))
            {
                string[] dirs = Directory.GetDirectories(dirName);
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Подкаталоги:");
                foreach (string dir in dirs)
                {
                    WriteLine(dir);
                }
                WriteLine();
                string[] files = Directory.GetFiles(dirName);
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Файлы:");
                foreach (string dir in files)
                {
                    WriteLine(dir);
                }
                return dirName;
            }
            else
            {
                return "Wrong way";
            }

        }
        public static void Help()
        {

        }
        public static void MoveFile(string path, string newPath) // Перемещение файла
        {
            CopyFile(path, newPath);
            DelFile(path);

            /*FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                File.Move(path, newPath);
            }*/
        }

        /*public static void CreateFile(string path) // создание файла
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    
                }
            }
        }
        */
        public static void CreateDirectory(string path, string subpath)//создание каталога
        {

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            DirectoryInfo newDir = new DirectoryInfo(path + @"\" + subpath);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            if (!newDir.Exists)
            {
                dirInfo.CreateSubdirectory(subpath);
            }
            else WriteLine("Папка существует");
        }

        //public static string MoveDirectory(string directory)
        //{
        //    DriveInfo[] drivers = DriveInfo.GetDrives();
        //    foreach (var driver in drivers)
        //    {
        //        if (driver.IsReady)
        //        {
        //            ForegroundColor = ConsoleColor.DarkGreen;
        //            WriteLine($"{driver.Name} ");
        //        }

        //    }
        //    WriteLine("Выберите диск");
        //    pathMove = ReadLine() + ":\\";
        //    do
        //    {
        //        Clear();
        //        Consol.Show(pathMove);
        //        WriteLine("Введите каталог в какой вы хотите перейти");
        //        newPathDirectory = ReadLine();
        //        pathMove = pathMove + newPathDirectory + @"\";
        //    }
        //    while (newPathDirectory != "11");
        //}
      }
 }
