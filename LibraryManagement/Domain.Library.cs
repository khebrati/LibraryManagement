global using static System.Console;
global using static System.Convert;
global using static Helpers.Displayer;
global using static Helpers.Reader;
global using static UI.Program;
global using static RandomDataGenerator.Randomizers.RandomizerFactory;
global using System.Text.RegularExpressions;
using RandomDataGenerator.FieldOptions;
using System.Text.RegularExpressions;
using System.Diagnostics.CodeAnalysis;

namespace Domain;
public class Library
{
    public List<Patron> Patrons { get; set; }
    public List<Book> Books { get; set; }
    public Library()
    {
        Patrons = new();
        Books = new();
        LoadInitialSamples();
    }

    public void AddBook()
    {
        
        Books.Add(GetBookInfoFromUser());
        WriteSuccess("Book was Added Sucsessfully");
        DisplayBooksInfo(Books);
    }
    
    public void AddPatron()
    {
        Patrons.Add(GetPatronInfoFromUser());
        WriteSuccess("Patron was Added Sucsessfully");
        DisplayPatronsInfo(Patrons);
    }

    public bool TryFindBookByKey(string key, out Book? foundBook)
    {
        foreach (Book b in Books)
        {
            if (b.Author == key || b.BookId == key || b.Title == key || b.ISBN == key || b.Genre == key)
            {
                foundBook = b;
                return true;
            }
        }
        WriteError("Book not found");
        foundBook = null;
        return false;
    }
    public bool TryFindBookByTitle(string title, out Book? foundBook)
    {
        foreach (Book b in Books)
        {
            if (b.Title == title)
            {
                foundBook = b;
                return true;
            }
        }
        WriteError("Book not found");
        foundBook = null;
        return false;
    }
    public bool TryFindBookByAuthor(string author, out Book? foundBook)
    {
        foreach (Book b in Books)
        {
            if (b.Author == author)
            {
                foundBook = b;
                return true;
            }
        }
        WriteError("Book not found");
        foundBook = null;
        return false;
    }
    public bool TryFindPatronByKey(string key, out Patron? foundPatron)
    {
        foreach (Patron p in Patrons)
        {
            if (p.Name == key || p.PatronId == key || p.Phone == key || p.Address == key || p.Email == key)
            {
                foundPatron = p;
                return true;
            }
        }
        WriteError("Patron not found");
        foundPatron = null;
        return false;
    }
    public bool TryFindPatronByName(string name, out Patron? foundPatron)
    {
        foreach (Patron p in Patrons)
        {
            if (p.Name == name)
            {
                foundPatron = p;
                return true;
            }
        }
        WriteError("Patron not found");
        foundPatron = null;
        return false;
    }
    public Book GetSampleBook()
    {
        FieldOptionsTextWords title = new();
        title.Max = 2;
        return new Book
        {
            Title = GetRandomizer(title).Generate()!,
            Author = GetRandomizer(new FieldOptionsFullName()).Generate()!,
            Genre = GetRandomizer(new FieldOptionsFullName()).Generate()!
        };
    }
    public Patron GetSamplePatron()
    {
        FieldOptionsTextRegex optionsRegexPhone = new();
        optionsRegexPhone.Pattern = @"09\d{9}";
        return new Patron
        {
            Email = GetRandomizer(new FieldOptionsEmailAddress()).Generate()!,
            Name = GetRandomizer(new FieldOptionsFullName()).Generate()!,
            Address = GetRandomizer(new FieldOptionsCity()).Generate() + ", " + GetRandomizer(new FieldOptionsCity()).Generate()!,
            Phone = GetRandomizer(optionsRegexPhone).Generate()!
        };
    }
    public void LoadInitialSamples()
    {
        Books.Add(GetSampleBook());
        Books.Add(GetSampleBook());
        Books.Add(GetSampleBook());
        Books.Add(GetSampleBook());

        Patrons.Add(GetSamplePatron());
        Patrons.Add(GetSamplePatron());
        Patrons.Add(GetSamplePatron());
        Patrons.Add(GetSamplePatron());
    }
    

}