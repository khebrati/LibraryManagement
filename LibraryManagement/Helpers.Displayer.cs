﻿using Domain;
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
            WriteLine($"{"Id",-30}{"Name",-30}{"Address",-30}{"Email",-40}{"Phone",-30}");
            ForegroundColor = previous;
            WriteLine(fullLine);
            foreach (Patron p in patrons)
            {
                WriteLine($"{p.PatronId,-30}{p.Name,-30}{p.Address,-30}{p.Email,-40}{p.Phone,-30}");
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
            WriteLine($"{"Id",-20}{"Title",-20}{"Author",-20}{"ISBN",-20}{"Genre",-20}{"Is Available",-20}{"Reserved By",-20}");
            ForegroundColor = previous;
            WriteLine(fullLine);
            foreach (Book b in books)
            {
                WriteLine($"{b.BookId,-20}{b.Title,-20}{b.Author,-20}{b.ISBN,-20}{b.Genre,-20}{b.Availability,-20}{b.BorrowedBy,-20}");
            }
            WriteLine(fullLine);
            WriteLine();
        }

    }
}
