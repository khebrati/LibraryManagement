global using static Helpers.RandomGenerator;
namespace Domain;
public class Book
{
    public string BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public string Genre { get; set; }
    public bool Availability { get; set; }
    public Patron? BorrowedBy { get; set; }
    public Book()
    {
        BookId = GenerateRandomId();
        ISBN = GenerateRandomISBN();
    }
}
