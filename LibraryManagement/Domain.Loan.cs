namespace Domain;
public class Loan
{
    public string LoanId { get; set; }
    public Book Book { get; set; }
    public Patron Patron { get; set; }
    public DateTime LoanDate {get; set; }
    public DateTime DueDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public bool IsFined { get; set; }
    public Fine Fine { get; set; }
    public Loan()
    {
        LoanId = GenerateRandomId();
        LoanDate = DateTime.Now;
        DueDate = DateTime.Now.AddMinutes(1);
    }

}