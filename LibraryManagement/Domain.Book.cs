namespace Domain;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int ISBN { get; set; }
    public string Genre { get; set; }
    public bool Availability { get; set; }
    public Patron? ReservedBy { get; set; }
    
}
