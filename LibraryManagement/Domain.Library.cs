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
        Patrons.Add(GetSamplePatron());
        Books.Add(GetSampleBook());
    }

    public void AddBook()
    {
        
        Books.Add(GetBookInfoFromUser());
        WriteSuccess("Book was Added Sucsessfully");
        DisplayBooks(Books);
        MainMenu();
    }
    
    public void AddPatron()
    {
        Patrons.Add(GetPatronInfoFromUser());
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
    public Book GetSampleBook()
    {
        FieldOptionsTextWords title = new();
        title.Max = 3;
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

}