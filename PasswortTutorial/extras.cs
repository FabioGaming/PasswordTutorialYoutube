using System;
using System.Collections.Generic;
using System.Text;

namespace PasswortTutorial
{
    class extras
    {


        public static void PrintColor(string message, String color)
        {
            switch (color)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "dark_green":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "dark_blue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "dark_cyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "dark_gray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "dark_magenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "dark_red:":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "dark_yellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "gray:":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("Invalid Color");
                    break;
            }
            Console.WriteLine(message);
            Console.ResetColor();

        }
    }
}
