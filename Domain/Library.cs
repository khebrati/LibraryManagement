namespace Domain;
public class Library
{
    public List<Patron> Patrons = new();
    public List<Book> Books = new();
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

}