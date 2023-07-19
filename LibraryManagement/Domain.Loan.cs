namespace Domain;
public class Loan
{
    public string Id { get; set; }
    public Book Book { get; set; }
    public Patron Patron { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsReturned { get; set; }
    public DateTime ReturnDate { get; set; }
    public Fine Fine { get; set; }
    public bool IsFined
    {
        get
        {
            if (IsReturned)
            {
                return ReturnDate > DueDate;
            }
            return DateTime.Now > DueDate;
        }
    }
    public Loan()
    {
        Id = GenerateRandomId();
        LoanDate = DateTime.Now;
        DueDate = DateTime.Now.AddMinutes(1);
        Fine = new()
        {
            Loan = this
        };
    }
    public void Return()
    {
        if(IsReturned)
        {
            WriteError($"The loan with Id: {Id} has already been returned");
        }
        IsReturned = true;
        Book.Availability = true;
        Book.BorrowedBy = null;
        ReturnDate = DateTime.Now;
    }
}