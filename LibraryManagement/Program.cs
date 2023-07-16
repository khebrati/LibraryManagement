global using static System.Console;
global using static System.Convert;
global using static Helpers.Reader;
global using static Helpers.Displayer;
using Domain;
using System.Text.RegularExpressions;
namespace UI;
public class Program
{
    public static Library library = new();
    public static void Main(string[] args)
    {
        WriteLine();
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Welcome to our Library!");
        MainMenu();
    }


    public static void MainMenu()
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
                PatronManagementMenu();
                break;
            default:
                WriteError("you can only choose from the list above! Try again: ");
                MainMenu();
                break;
        }

    }
    public static void LibraryMenu()
    {
        WriteLine();
        WriteLine();
        WriteInfo("What do you want to do?");
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
                library.AddBook();
                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                library.AddPatron();
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
                MainMenu();
                break;
            default:
                WriteError("You can only choose from the above list!");
                break;
        }


    }
    
    public static Patron ChoosePatron()
    {
        WriteLine();
        WriteLine("List of Available Patrons:");
        DisplayPatrons(library.Patrons);
        WriteInfo("enter the patron to manage(Id, Name or ...) : ");
        Patron? toBeFound = new();
        while(!library.TryFindPatron(ReadNotEmptyString(), out toBeFound))
        {
            WriteError("No patron with such specifications exist. Try again: ");
        }
        return toBeFound!;
    }
    public static void PatronManagementMenu()
    {
        Patron patron = ChoosePatron();
        WriteLine();
        WriteInfo("Patrons Management Menu:");
    }
    
    
    
    
    
    
    
}