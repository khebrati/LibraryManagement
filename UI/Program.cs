global using static System.Console;
using Domain;
public class UI
{
    public static Library library = new();
    public static void Main(string[] args)
    {
        WriteLine();
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Welcome to our Library!");
        WriteLine();
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
        }
        static void LibraryMenu()
        {
            WriteLine();
            WriteLine();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("What do you want to do?");
            ForegroundColor = ConsoleColor.White;
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
            WriteLine();
            WriteLine("Enter the Book's details:");

        }

    }
}