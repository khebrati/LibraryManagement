global using static System.Console;
global using static System.Convert;
global using static Helpers.Reader;
global using static Helpers.Displayer;
using Domain;
using System.Text.RegularExpressions;
namespace UI;
public class Program
{
    public static Library Library = new();
    public static void Main(string[] args)
    {
        WriteLine();
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Welcome to our Library!");
        WriteLine();
        ShowMainMenu();
    }


    public static void ShowMainMenu()
    {
        WriteInfo("Main Menu");
        ForegroundColor = ConsoleColor.White;
        WriteLine($"1)Manage The Library");
        WriteLine($"2)Manage Patrons");
        WriteLine($"3)Exit the Program");
        switch (ReadKey().Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                WriteLine();
                ShowLibraryManagementMenu();
                ShowMainMenu();
                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                WriteLine();
                ShowPatronManagementMenu();
                ShowMainMenu();
                break;
            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                WriteLine();
                break;
            default:
                WriteLine();
                WriteError("you can only choose from the list above! Try again: ");
                ShowMainMenu();
                break;
        }

    }
    public static void ShowLibraryManagementMenu()
    {
        WriteInfo("Library Management Menu");
        WriteLine($"1)Add a Book");
        WriteLine($"2)Add a Patron");
        WriteLine($"3)Search for a book by title");
        WriteLine($"4)Search for a book by author");
        WriteLine($"5)Search for a patron by name");
        WriteLine($"6)Generate overdue book report");
        WriteLine($"7)Last Menu");
        GetMainMenuKey();

    }

    private static void GetMainMenuKey()
    {
        switch (ReadKey().Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                WriteLine();
                Library.AddBook();
                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                WriteLine();
                Library.AddPatron();
                break;
            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                WriteLine();
                WriteInfo("Write The Book's title");
                Write("Title: ");
                string title = ReadNotEmptyString();
                List<Book> foundBooksByTitle = Library.Books.FindAll(new(book => book.Title == title));
                if(foundBooksByTitle.Count == 0)
                {
                    WriteError("No books were found");
                    break;
                }
                DisplayBooksInfo(foundBooksByTitle);
                break;
            case ConsoleKey.D4:
            case ConsoleKey.NumPad4:
                WriteLine();
                WriteInfo("Write The Book's Author");
                string author = ReadNotEmptyString();
                List<Book> foundBooksByAuthor = Library.Books.FindAll(new(book => book.Author == author));
                if (foundBooksByAuthor.Count == 0)
                {
                    WriteError("No books were found");
                    break;
                }
                DisplayBooksInfo(foundBooksByAuthor);
                break;
            case ConsoleKey.D5:
            case ConsoleKey.NumPad5:
                WriteLine();
                WriteInfo("Write The Patron's Name");
                Write("Name: ");
                string name = ReadNotEmptyString();
                List<Patron> foundPatrons = Library.Patrons.FindAll(new(patron => patron.Name == name));
                if (foundPatrons.Count == 0)
                {
                    WriteError("No patrons were found");
                    break;
                }
                DisplayPatronsInfo(foundPatrons);
                break;
            case ConsoleKey.D6:
            case ConsoleKey.NumPad6:
                WriteLine();
                //GenerateBookReport();
                break;
            case ConsoleKey.D7:
            case ConsoleKey.NumPad7:
                WriteLine();
                break;
            default:
                WriteLine();
                WriteError("You can only choose from the above list!");
                ShowLibraryManagementMenu();
                break;
        }
    }

    public static bool TryChooseFromExistingPatronsMenu(out Patron? chosen)
    {
        DisplayPatronsInfo(Library.Patrons);
        WriteInfo("Enter the patron to choose(Id, Name or ...) : ");
        if(Library.TryFindPatronByKey(ReadNotEmptyString(), out Patron? found))
        {
            chosen = found;
            return true;
        }
        chosen = null;
        return  false ;
    }

    


    public static bool TryChooseFromExistingBooksMenu(out Book? chosen)
    {
        DisplayBooksInfo(Library.Books);
        WriteInfo("enter the book to choose(Id, Name or ...) : ");
        if (Library.TryFindBookByKey(ReadNotEmptyString(), out Book? found))
        {
            chosen = found;
            return true;
        }
        chosen = null;
        return false ;
    }
    

    public static bool TryChooseFromPatronLoansMenu(Patron patron,out Loan? chosen)
    {
        DisplayLoansInfo(patron.Loans);
        WriteInfo("enter the Loan to choose(loan Id or book title) : ");
        if (patron.TryFindLoanByKey(ReadNotEmptyString(), out Loan? found))
        {
            chosen = found;
            return true;
        }
        chosen = null;
        return false;
    }

    


    public static void ShowPatronManagementMenu()
    {
        if(TryChooseFromExistingPatronsMenu(out Patron? chosenPatron))
        {

            WriteInfo("Patrons Management Menu:");
            WriteLine("1)Borrow A Book");
            WriteLine("2)Return A Book");
            WriteLine("3)Last Menu");
            GetPatronMenuKey(chosenPatron);
        }


    }

    public static void GetPatronMenuKey(Patron chosenPatron)
    {
        switch (ReadKey().Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                WriteLine();
                if (TryChooseFromExistingBooksMenu(out Book? chosenBook))
                {
                    chosenPatron!.Borrow(chosenBook!);
                }
                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                WriteLine();
                if (TryChooseFromPatronLoansMenu(chosenPatron!, out Loan? chosenLoan))
                {
                    chosenLoan!.Return();
                }
                break;
            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                break;
            default:
                WriteError("you can only choose from the list");
                break;

        }
    }






}