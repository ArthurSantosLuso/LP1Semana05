using System;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CanvasImage image = new CanvasImage("tux.jpg"); 

            if (args.Length == 0)
            {
                image.MaxWidth(24);
            }
            else
            {
                image = new CanvasImage(args[0]);

                image.MaxWidth(int.Parse(args[1]));
            }


            AnsiConsole.Write(image);
        }
    }
}
