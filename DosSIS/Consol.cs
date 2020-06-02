
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            string nameFile, proverka;
            WriteLine($"Введит название файла");
            nameFile = ReadLine();
            nameFile = path + nameFile;
            FileInfo fileInf = new FileInfo(nameFile);
            if (fileInf.Exists)
            {
                WriteLine($"Вы уверены что хотите удалить '{nameFile}' ?! Нажмите 'Y' чтоб согласиться");
                proverka = ReadLine();
                if (proverka == "Y" || proverka == "y")
                {
                    File.Delete(nameFile);
                }
            }
        }
        public static void ShowDisk()//Показ жестких дисков
        {
            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach (var driver in drivers)
            {
                if (driver.IsReady)
                {
                    ForegroundColor = ConsoleColor.DarkGreen;
                    WriteLine($"{driver.Name}{GetGB(driver.TotalSize)}GB TotalSize({GetGB(driver.AvailableFreeSpace)}GB FreeSpace)");
                    ForegroundColor = ConsoleColor.White;
                }
            }
        }
        static double GetGB(long bytes)//Пересчет в Gb
        {
            var result = (double)bytes / (1024 * 1024 * 1024);
            return Math.Round(result, 2);
        }
        public static void Show(string dirName)//показ каталогов и файлов
        {
            if (Directory.Exists(dirName))
            {
                string[] dirs = Directory.GetDirectories(dirName);
                ForegroundColor = ConsoleColor.White;
                WriteLine("Подкаталоги:");
                foreach (string dir in dirs)
                {
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine(dir);
                    ForegroundColor = ConsoleColor.White;
                }
                string[] files = Directory.GetFiles(dirName);
                WriteLine("Файлы:");
                foreach (string dir in files)
                {
                    ForegroundColor = ConsoleColor.Cyan;
                    WriteLine(dir);
                    ForegroundColor = ConsoleColor.White;
                }

            }
        }
        public static void Help()
        {
            WriteLine("_______________________________");
            WriteLine("      Доступные команды        ");
            WriteLine("_______________________________");
            WriteLine("Move - Выбрать нужный каталог  ");
            WriteLine("_______________________________");
            WriteLine("Copy - Копировать файл         ");
            WriteLine("_______________________________");
            WriteLine("Del - Удалить файл             ");
            WriteLine("_______________________________");
            WriteLine("MoveFile - Переместить файл    ");
            WriteLine("_______________________________");
            WriteLine("CreateDirec - Создать папку    ");
        }

        public static void HelpLocal()
        {
            WriteLine("      Доступные команды          ");
            WriteLine("**********************************");
            WriteLine("--> Open - чтоб открыть файл       ");
            WriteLine("--> Del- чтоб удалить  файл       ");
            WriteLine("--> CreateDir- чтоб создать каталог");
            ReadKey();

        }
        public static void MoveFile(string path, string newPath) // Перемещение файла
        {
            CopyFile(path, newPath);
            DelFile(path);
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
                WriteLine(path + @"\" + subpath);
                ReadKey();
            }
            else WriteLine("Папка существует");
        }



        //public static void OpenFile(string path) // открытие текстового файла
        //{
        //    using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read))
        //    {
        //        byte[] b = new byte[1024];
        //        UTF8Encoding temp = new UTF8Encoding(true);

        //        while (fs.Read(b, 0, b.Length) > 0)
        //        {
        //            Console.WriteLine(temp.GetString(b));
        //        }

        //    }
        //}
        //public static void OpenExeFile(string path)// открытие exe файла
        //{
        //    Process.Start(path);
        //}
        public static void OpenFile(string pathMove)//открытие любого документа в фоновом режиме
        {
            string FileName;
            WriteLine("ВВедите название файла и его расширение");
            FileName = ReadLine();
            string commandText = pathMove + FileName;
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}
