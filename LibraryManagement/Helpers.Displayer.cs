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
        public static void DisplayPatronsInfo(List<Patron> patrons)
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
                DisplayPatronInfo(p);
            }
            WriteLine(fullLine);
        }
        public static void DisplayPatronInfo(Patron patron)
        {
            WriteLine($"{patron.PatronId,-30}{patron.Name,-30}{patron.Address,-30}{patron.Email,-40}{patron.Phone,-30}");
        }
        public static void DisplayBooksInfo(List<Book> books)
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
                DisplayBookInfo(b);
            }
            WriteLine(fullLine);
        }
        public static void DisplayBookInfo(Book book)
        {
            WriteLine($"{book.BookId,-20}{book.Title,-20}{book.Author,-20}{book.ISBN,-20}{book.Genre,-20}{book.Availability,-20}{book.BorrowedBy,-20}");
        }
        public static void DisplayLoansInfo(List<Loan> loans)
        {
            WriteInfo("Loans");
            string fullLine = new string('-', WindowWidth);
            WriteLine(fullLine);
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"{"LoanId",-10}{"Returned?",-12}{"Book",-20}{"Patron",-20}{"LoanDate",-20}{"DueDate",-20}{"ReturnDate",-20}{"IsFined",-12}{"FineAmount",-12}{"Paid",-20}");
            ForegroundColor = previous;
            WriteLine(fullLine);
            foreach (Loan l in loans)
            {
                WriteLine($"{l.Id,-10}{l.IsReturned,-12}{l.Book,-20}{l.Patron,-20}{l.LoanDate.ToString("MM-dd HH-mm-ss"),-20}{l.DueDate.ToString("MM-dd HH-mm-ss"),-20}{l.ReturnDate.ToString("MM-dd HH-mm-ss"),-20}{l.IsFined,-12}{l.Fine.Amount,-12}{l.Fine.PaymentStatus,-20}");
            }
            WriteLine(fullLine);
        }

    }
}
