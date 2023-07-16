global using static System.Console;
global using static System.Convert;
global using static Helpers.MessageDisplayer;
global using static Helpers.Reader;
namespace Domain;
public class Library
{
    public List<Patron> Patrons { get; set; }
    public List<Book> Books { get; set; }
    public Library()
    {
        Patrons = new();
        Books = new();
    }

   public static void DisplayPatrons(string message,List<Patron> patrons)
    {
        WriteLine(message);
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
    public void AddBook()
    {
        Book book = new();
        WriteLine();
        DisplayInfo("Enter the Book's details:");
        Write("Title: ");
        book.Title = ReadNotEmptyString();
        Write("Id: ");
        book.BookId = ReadNotEmptyInt();
        Write("Author: ");
        book.Author = ReadNotEmptyString();
        Write("ISBN: ");
        book.ISBN = ReadNotEmptyInt();
        Write("Genre: ");
        book.Genre = ReadNotEmptyString();
        book.Availability = true;
        Books.Add(book);
        DisplaySuccess("Book was Added Sucsessfully");
    }
    public void AddPatron()
    {
        Patron patron = new();
        WriteLine();
        DisplayInfo("Enter the Patrons's details:");
        Write("Name: ");
        patron.Name = ReadNotEmptyString();
        Write("Id: ");
        patron.PatronId = ReadNotEmptyInt();
        Write("Email: ");
        patron.Email = ReadNotEmptyString();
        Write("Phone: ");
        patron.Phone = ReadNotEmptyInt();
        Write("Address: ");
        patron.Address = ReadNotEmptyString();
        Patrons.Add(patron);
        DisplaySuccess("Book Created Sucsessfully");
    }

}