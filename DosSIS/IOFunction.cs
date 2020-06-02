using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

namespace DosSIS
{
    class IOFunction
    {
        public static List<string> temp = new List<string>();
        public static void MoveDirectory()
        {
            Logo();
            string pathMove, command;
            int count = 0;
            Consol.ShowDisk();
            WriteLine("Выберите диск");
            pathMove = ReadLine() + ":\\";
            temp.Add(pathMove);
            while (!Directory.Exists(pathMove))
            {
                if (!Directory.Exists(pathMove))
                {
                    WriteLine("Не верный путь проверьте ввод");
                }
                pathMove = ReadLine() + ":\\";
                temp.Add(pathMove);
            }
            
            do
            {
                Clear();
                Logo();
                Consol.Show(temp[count]);
                WriteLine("Чтоб перейти в другой каталог введите его название.Чтоб узнать доступные комманды нажмите Help");
                command = ReadLine();
                if (command == "Open")
                {
                    Consol.OpenFile(temp[count]);
                }
                else if (command == "Del")
                {
                    Consol.DelFile(temp[count]);
                }
                else if (command == "Help")
                {
                    Consol.HelpLocal();
                }
                else if(command == "Back")
                {
                    temp.Remove(temp[count]);
                    count--;
                    
                }
                else if (command == "End" || command == "end")
                {
                    count = 0;
                    break;
                }
                else if (command == "CreateDir")
                {
                    string pr;
                    WriteLine("ВВедите название папки");
                    pr = ReadLine();
                    Consol.CreateDirectory(temp[count], pr);
                    

                }
                else
                {

                    if (Directory.Exists(temp[count] + command + @"\"))
                    {
                        pathMove = temp[count] + command + @"\";
                        temp.Add(pathMove);
                        count++;
                    }
                    else
                    {
                        WriteLine("Не верный путь проверьте ввод");
                        ReadKey();
                    }
                }
            } while (command != "End" || command != "end");
        }
        public static void Logo()
        {
            ForegroundColor = ConsoleColor.Cyan; Write("    #####      ###     #####"); ForegroundColor = ConsoleColor.Red; WriteLine("     #####  ##  ##### ");
            ForegroundColor = ConsoleColor.Cyan; Write("   ##    #   #    #   #     "); ForegroundColor = ConsoleColor.Red; WriteLine("    #      ##  #      ");
            ForegroundColor = ConsoleColor.Cyan; Write("  ##     #  #     #  ####   "); ForegroundColor = ConsoleColor.Red; WriteLine("   ####   ##  ####    ");
            ForegroundColor = ConsoleColor.Cyan; Write(" ##    #    #    #      #   "); ForegroundColor = ConsoleColor.Red; WriteLine("     #  ##      #    ");
            ForegroundColor = ConsoleColor.Cyan; Write("######       ###   #####    "); ForegroundColor = ConsoleColor.Red; WriteLine("#####  ##  #####     ");
            WriteLine();
        }
    }
}
