global using static System.Console;
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
        //asks user to enter details of book in a specific format
        //parses the string and add related object + input validation
    }
    public void AddPatron()
    {
        //asks user to enter details of Patron in a specific format
        //parses the string and add related object
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

}