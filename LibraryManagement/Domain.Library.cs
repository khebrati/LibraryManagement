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