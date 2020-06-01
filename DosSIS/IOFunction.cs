using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

namespace DosSIS
{
    class IOFunction
    {
        public static void MoveDirectory()
        {
            string pathMove, command, FileName;
            Consol.ShowDisk();
            WriteLine("Выберите диск");
            pathMove = ReadLine() + ":\\";
            while (!Directory.Exists(pathMove))
            {
                if (!Directory.Exists(pathMove))
                {
                    WriteLine("Не верный путь проверьте ввод");
                }
                pathMove = ReadLine() + ":\\";

            }
            do
            {
                Clear();
                Consol.Show(pathMove);
                WriteLine("Чтоб перейти в другой каталог введите его название.Чтоб узнать доступные комманды нажмите Help");
                command = ReadLine();
                if (command == "OpenFile")
                {
                    Consol.OpenFile(pathMove);
                }
                else if (command == "Help")
                {
                    Consol.HelpLocal();
                }
                else if (command == "End" || command == "end")
                {
                    break;
                }
                else
                {

                    if (Directory.Exists(pathMove + command + @"\"))
                    {
                        pathMove = pathMove + command + @"\";
                    }
                    else
                    {
                        WriteLine("Не верный путь проверьте ввод");
                        ReadKey();
                    }
                }
            } while (command != "End" || command != "end");
        }
    }
}
