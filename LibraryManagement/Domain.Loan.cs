namespace Domain;
public class Loan
{
    public string LoanId { get; set; }
    public Book Book { get; set; }
    public Patron Patron { get; set; }
    public DateTime LoanDate {get; set; }
    public DateTime DueDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public Loan(Book book,Patron patron)
    {
        Random r = new();
        LoanId = r.Next(1000).ToString();
        Book = book;
        Patron = patron;
        LoanDate = DateTime.Now;
        DueDate = DateTime.Now.AddDays(14);
    }

}