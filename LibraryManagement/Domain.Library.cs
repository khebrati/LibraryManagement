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
        WriteInfo("Enter the Book's details:");
        Write("Title: ");
        book.Title = ReadNotEmptyString();
        Write("Id: ");
        book.BookId = ReadNotEmptyString();
        Write("Author: ");
        book.Author = ReadNotEmptyString();
        Write("ISBN: ");
        book.ISBN = ReadNotEmptyString();
        Write("Genre: ");
        book.Genre = ReadNotEmptyString();
        book.Availability = true;
        Books.Add(book);
        WriteSuccess("Book was Added Sucsessfully");
        DisplayBooks(Books);
        MainMenu();
    }
    public void AddPatron()
    {
        Patron patron = new();
        WriteLine();
        WriteInfo("Enter the Patrons's details:");
        Write("Name: ");
        patron.Name = ReadNotEmptyString();
        Write("Id: ");
        patron.PatronId = ReadNotEmptyString();
        Write("Email: ");
        patron.Email = ReadNotEmptyString();
        Write("Phone: ");
        patron.Phone = ReadNotEmptyString();
        Write("Address: ");
        patron.Address = ReadNotEmptyString();
        Patrons.Add(patron);
        WriteSuccess("Patron was Added Sucsessfully");
        DisplayPatrons(Patrons);
        MainMenu();
    }
    public bool TryFindBook(string key, out Book? foundBook)
    {
        foreach (Book b in Books)
        {
            if (b.Author == key || b.BookId == key || b.Title == key || b.ISBN == key || b.Genre == key)
            {
                foundBook = b;
                return true;
            }
        }
        foundBook = null;
        return false;
    }
    public bool TryFindPatron(string key, out Patron? foundPatron)
    {
        foreach (Patron p in Patrons)
        {
            if (p.Name == key || p.PatronId == key || p.Phone == key || p.Address == key || p.Email == key)
            {
                foundPatron = p;
                return true;
            }
        }
        foundPatron = null;
        return false;
    }

}