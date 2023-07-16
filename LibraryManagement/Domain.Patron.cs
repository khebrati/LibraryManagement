namespace Domain;

public class Patron
{
    public string PatronId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public List<Loan> Loans {get;set;}
    public Patron()
    {
        Loans = new();
        Random r = new();
        PatronId = r.Next().ToString();
    }
    public override string ToString()
    {
        return Name;
    }
    public void Borrow(Book book)
    {
        book.Availability = false;
        Loan loan = new(book,this);
        Loans.Add(loan);
        book.BorrowedBy = this;
    }
}

