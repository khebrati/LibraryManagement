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
        Random r = new();
        BookId = r.Next(1000).ToString();
        ISBN = r.Next(10001,1000000).ToString();
    }
}
