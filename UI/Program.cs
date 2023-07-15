global using static System.Console;
using Domain;
public class UI
{
    public static void Main(string[] args)
    {
        Library library = new();
        WriteLine();
        ShowInfo(" Welcome to Our Library");
        switch(MainOptions().Key)
        {
            case ConsoleKey.NumPad1:
            case ConsoleKey.D1:
                ManageTheLibrary();
                break;
            case ConsoleKey.NumPad2:
            case ConsoleKey.D2:
                ManagePatrons();
                break;
        }
    }

    static void ShowInfo(string message)
    {
        WriteLine();
        ConsoleColor previous = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine(message);
        WriteLine();
        ForegroundColor = previous;
    }
    
    static ConsoleKeyInfo MainOptions()
    {
        ConsoleColor previous = Console.ForegroundColor;
        ForegroundColor = ConsoleColor.Blue;
        WriteLine($"1)Manage The Library");
        WriteLine($"2)Manage Patrons");
        ForegroundColor = previous;
        return ReadKey();
    }
    static ConsoleKeyInfo ManageTheLibrary()
    {
        ConsoleColor previous = Console.ForegroundColor;
        ForegroundColor = ConsoleColor.DarkBlue;
        WriteLine($"\t1)Add a Book");
        WriteLine($"\t2)Add a Patron");
        WriteLine($"\t3)Search for a book by title");
        WriteLine($"\t4)Search for a book by author");
        WriteLine($"\t5)Search for a patron by name");
        WriteLine($"\t6)Generate overdue book report");
        WriteLine($"\t7)Exit the Program");
        ForegroundColor = previous;
        return new ConsoleKeyInfo();
    }
    static ConsoleKeyInfo ManagePatrons()
    {
        ConsoleColor previous = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkBlue;
        WriteLine("\tList of Available Patrons:");
        //TODO: list of Patrons
        WriteLine("\tWhat Patron do you want to access?");
        //WriteLine($"\t\t1)Add a Book");
        //WriteLine($"\t\t2)Add a Patron");
        //WriteLine($"\t\t3)Search for a book by title");
        //WriteLine($"\t\t4)Search for a book by author");
        //WriteLine($"\t\t5)Search for a patron by name");
        //WriteLine($"\t\t6)Generate overdue book report");
        //WriteLine($"\t\t7)Exit the Program");
        ForegroundColor = previous;
        return new ConsoleKeyInfo();
    }

}