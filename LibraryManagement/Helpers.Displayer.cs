using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class Displayer
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
        public static void DisplayPatrons(List<Patron> patrons)
        {
            string fullLine = new string('-', WindowWidth);
            WriteLine(fullLine);
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"{"Id",-20}{"Name",-20}{"Address",-20}{"Email",-20}{"Phone",-20}");
            ForegroundColor = previous;
            WriteLine(fullLine);
            foreach (Patron p in patrons)
            {
                WriteLine($"{p.PatronId,-20}{p.Name,-20}{p.Address,-20}{p.Email,-20}{p.Phone,-20}");
            }
            WriteLine(fullLine);
            WriteLine();
        }
        public static void DisplayBooks(List<Book> books)
        {
            string fullLine = new string('-', WindowWidth);
            WriteLine(fullLine);
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"{"Id",-20}{"Title",-20}{"Author",-20}{"ISBN",-20}{"Genre",-20}{"Is Available",-20}{"Reserved By",-20}");
            ForegroundColor = previous;
            WriteLine(fullLine);
            foreach (Book b in books)
            {
                WriteLine($"{b.BookId,-20}{b.Title,-20}{b.Author,-20}{b.ISBN,-20}{b.Genre,-20}{b.Availability,-20}{b.ReservedBy,-20}");
            }
            WriteLine(fullLine);
            WriteLine();
        }

    }
}
