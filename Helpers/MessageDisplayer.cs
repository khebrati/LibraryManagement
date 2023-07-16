global using static System.Console;
global using static System.Convert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static  class MessageDisplayer
    {
        public static void DisplayError(string message)
        {
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Red;
            WriteLine(message);
            ForegroundColor = previous;
        }
        public static void DisplayInfo(string message)
        {
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(message);
            ForegroundColor = previous;
        }
        public static void DisplaySuccess(string message)
        {
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Green;
            WriteLine(message);
            ForegroundColor = previous;
        }
    }
}
