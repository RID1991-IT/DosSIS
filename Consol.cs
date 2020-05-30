using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;

namespace Console
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
                foreach (string dir in dirs)
                {
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Подкаталоги:");
                    WriteLine(dir);
                }
                WriteLine();
                string[] files = Directory.GetFiles(dirName);
                foreach (string dir in files)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Файлы:");
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
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                File.Move(path, newPath);
            }
        }

        public static void CreateFile(string path) // создание файла
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    
                }
            }
        }
        public static void CreateDirectory(string path, string subpath)//создание каталога
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);
        }
    }
}
