global using static System.Console;
global using static System.Convert;
using Domain;
public class UI
{
    public static Library library = new();
    public static void Main(string[] args)
    {
        WriteLine();
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Welcome to our Library!");
        MainOptions();
    }


    static void MainOptions()
    {
        WriteLine();
        WriteLine();
        ForegroundColor = ConsoleColor.White;
        WriteLine($"1)Manage The Library");
        WriteLine($"2)Manage Patrons");
        WriteLine($"3)Exit the Program");
        switch (ReadKey().Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                LibraryMenu();
                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                ChoosePatron();
                break;
            default:
                DisplayError("you can only choose from the list above! Try again: ");
                MainOptions();
                break;
        }
        static void LibraryMenu()
        {
            WriteLine();
            WriteLine();
            DisplayInfo("What do you want to do?");
            WriteLine($"1)Add a Book");
            WriteLine($"2)Add a Patron");
            WriteLine($"3)Search for a book by title");
            WriteLine($"4)Search for a book by author");
            WriteLine($"5)Search for a patron by name");
            WriteLine($"6)Generate overdue book report");
            WriteLine($"7)Last Menu");
            switch (ReadKey().Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    AddBook();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    //AddPatron();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    //SearchBookByTitle();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    //SearchBookByAuthor();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    //SearchPatronByName();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    //GenerateBookReport();
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    MainOptions();
                    break;
            }


        }
        static void ChoosePatron()
        {
            WriteLine();
            WriteLine();
            ForegroundColor = ConsoleColor.DarkBlue;
            Library.DisplayPatrons("List of Available Patrons:", library.Patrons);
            WriteLine("What Patron do you want to manage?");

        }
        static void AddBook()
        {
            Book book = new();
            WriteLine();
            DisplayInfo("Enter the Book's details:");
            Write("Title: ");
            book.Title = ReadNotEmptyString();
            Write("Id: ");
            book.BookId = ReadNotEmptyInt();
            Write("Author: ");
            book.Author= ReadNotEmptyString();
            Write("ISBN: ");
            book.ISBN = ReadNotEmptyInt();
            Write("Genre: ");
            book.Genre = ReadNotEmptyString();
            book.Availability = true;
            DisplaySuccess("Book Created Sucsessfully");
        }
        static string ReadNotEmptyString()
        {
            string? input;
            while (true)
            {
                input = ReadLine();
                if (input is not null && input != "")
                {
                    break;
                }
                DisplayError("Input can not be null! try again:");
               
            }
            return input;
        }
        static int ReadNotEmptyInt()
        {
            int input;
            while(true)
            {
                try
                {
                    input = ToInt32(ReadLine());
                    break;
                }
                catch
                {
                    DisplayError("your input must be an integer, try again: ");
                }
            }
            return input;
        }
        static void DisplayError(string message)
        {
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Red;
            WriteLine(message);
            ForegroundColor = previous;
        }
        static void DisplayInfo(string message)
        {
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(message);
            ForegroundColor = previous;
        }
        static void DisplaySuccess(string message)
        {
            ConsoleColor previous = ForegroundColor;
            ForegroundColor = ConsoleColor.Green;
            WriteLine(message);
            ForegroundColor = previous;
        }


    }
}