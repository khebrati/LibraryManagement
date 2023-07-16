global using static System.Console;
global using static System.Convert;
global using static Helpers.Displayer;
global using static Helpers.Reader;
global using static UI.Program;
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
        DisplayInfo("List of Current Books:");
        DisplayBooks(Books);
        LibraryMenu();
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
        DisplaySuccess("Patron was Added Sucsessfully");
        DisplayInfo("List of Current Patrons:");
        DisplayPatrons(Patrons);
        LibraryMenu();
    }

}