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
            SetWindowSize(Math.Min(150, LargestWindowWidth), Math.Min(50, LargestWindowHeight));
            Console.Title = "DosSIS";
            IOFunction.MoveDirectory();
        }
    }
}
