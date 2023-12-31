using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace Domain;
public class Fine
{
    public Loan Loan { get; set; }
    public string FineId { get; init; }
    public int Amount
    {
        get
        {
            if (Loan.IsReturned)
            {
                if(Loan.IsFined)
                {
                    return (int)(Loan.ReturnDate - Loan.DueDate).TotalSeconds / 10;
                }
                return 0;
            }
            else
            {
                if ((DateTime.Now < Loan.DueDate))
                {
                    return 0;
                }
                return (int)(DateTime.Now - Loan.DueDate ).TotalSeconds / 10;
            }

        }
        set
        {
            Amount = value;
        }
    }
    public bool PaymentStatus { get; set; }
    public Fine()
    {
        FineId = GenerateRandomId();
    }
}