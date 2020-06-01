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
            string str;

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
                        IOFunction.MoveDirectory();
                        break;
                    case "Help":
                        Consol.Help();
                        break;
                    //case "openfile":
                    //    Consol.OpenFile(path);
                    //    break;
                    //case "openfile.exe":
                    //    Consol.OpenExeFile(path);
                    //    break;
                   
                        
                       
                }
            } while (str != "End" || str != "end");
        }
    }
}
