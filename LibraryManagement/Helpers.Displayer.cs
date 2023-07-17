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
        public static void WriteError(string message)
        {
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Red;
            WriteLine(message);
            ForegroundColor = previous;
        }
        public static void WriteInfo(string message)
        {
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(message);
            ForegroundColor = previous;
        }
        public static void WriteSuccess(string message)
        {
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Green;
            WriteLine(message);
            ForegroundColor = previous;
        }
        public static void DisplayPatrons(List<Patron> patrons)
        {
            WriteInfo("Available Patrons");
            string fullLine = new string('-', WindowWidth);
            WriteLine(fullLine);
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"{"Id",-30}{"Name",-30}{"Address",-30}{"Email",-30}{"Phone",-30}");
            ForegroundColor = previous;
            WriteLine(fullLine);
            foreach (Patron p in patrons)
            {
                WriteLine($"{p.PatronId,-30}{p.Name,-30}{p.Address,-30}{p.Email,-30}{p.Phone,-30}");
            }
            WriteLine(fullLine);
            WriteLine();
        }
        public static void DisplayBooks(List<Book> books)
        {
            WriteInfo("Available Books");
            string fullLine = new string('-', WindowWidth);
            WriteLine(fullLine);
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"{"Id",-30}{"Title",-30}{"Author",-30}{"ISBN",-30}{"Genre",-30}{"Is Available",-30}{"Reserved By",-30}");
            ForegroundColor = previous;
            WriteLine(fullLine);
            foreach (Book b in books)
            {
                WriteLine($"{b.BookId,-30}{b.Title,-30}{b.Author,-30}{b.ISBN,-30}{b.Genre,-30}{b.Availability,-30}{b.BorrowedBy,-30}");
            }
            WriteLine(fullLine);
            WriteLine();
        }

    }
}
