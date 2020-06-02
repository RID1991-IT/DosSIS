using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;
using System.Text.RegularExpressions;

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
                WriteLine("Чтобы перейти в другой каталог введите его название. Чтобы узнать доступные комманды нажмите Help");
                command = ReadLine();
                if (Regex.IsMatch(command, "Open", RegexOptions.IgnoreCase))
                {
                    Consol.OpenFile(temp[count]);
                }
                else if (Regex.IsMatch(command, "del", RegexOptions.IgnoreCase))
                {
                    Consol.DelFile(temp[count]);
                }
                else if (Regex.IsMatch(command, "help", RegexOptions.IgnoreCase))
                {
                    Consol.HelpLocal();
                }
                else if(Regex.IsMatch(command, "back", RegexOptions.IgnoreCase))
                {
                    temp.Remove(temp[count]);
                    count--;
                }
                else if (Regex.IsMatch(command, "end", RegexOptions.IgnoreCase))
                {
                    count = 0;
                    break;
                }
                else if (Regex.IsMatch(command, "createdir", RegexOptions.IgnoreCase))
                {
                    string pr;
                    WriteLine("Введите название папки");
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
                        WriteLine("Неверный путь проверьте ввод");
                        ReadKey();
                    }
                }
            } while (!Regex.IsMatch(command, "Open", RegexOptions.IgnoreCase));
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
