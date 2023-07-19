namespace Domain;
public class Loan
{
    public string LoanId { get; set; }
    public Book Book { get; set; }
    public Patron Patron { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public Fine Fine { get; set; }
    public bool IsFined
    {
        get
        {
            if(ReturnDate == DateTime.MinValue) //loan not yet been returned, S
            {
                return false;
            }
            return (ReturnDate - DueDate).Ticks < 0;
        }
    }
    public Loan()
    {

        LoanId = GenerateRandomId();
        LoanDate = DateTime.Now;
        DueDate = DateTime.Now.AddMinutes(1);
        Fine = new();
    }
    public void Return()
    {
        Book.Availability = true;
        Book.BorrowedBy = null;
        ReturnDate = DateTime.Now;
        if (IsFined)
        {
            CalculateFine();
        }
    }
    public void CalculateFine()
    {
        if (!IsFined)
        {
            WriteError($"The loan transaction with ID {LoanId} was returned on time and can not be fined!");
        }
        Fine.Amount = (ReturnDate - DueDate).TotalSeconds * 10;
    }
}