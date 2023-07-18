using static System.Reflection.Metadata.BlobBuilder;

namespace Domain;

public class Patron
{
    public string PatronId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public List<Loan> Loans { get; set; }
    public Patron()
    {
        PatronId = GenerateRandomId();
        Loans = new();
    }
    public override string ToString()
    {
        return Name;
    }
    public void Borrow(Book book)
    {
        book.Availability = false;
        Loan loan = new()
        {
            Book = book,
            Patron = this,
        };
        Loans.Add(loan);
        book.BorrowedBy = this;
        WriteSuccess($"{this} has seccessfully borrowed {book}");
        WriteError($"Book must be returned before one minute, or the {this} will be fined!");
    }
    public bool TryFindLoan(string key, out Loan? foundLoan)
    {
        foreach (Loan l in Loans)
        {
            if (l.Book.Title == key || l.LoanId == key )
            {
                foundLoan = l;
                return true;
            }
        }
        foundLoan = null;
        return false;
    }
}

