using Figgle;
using System;
using static System.Console;

namespace maze
{
    class Program
    {
        static void Main(string[] args)
        {
            Write(FiggleFonts.Standard.Render("Maze Game"));
            ReadKey(true);
        }
    }
}
