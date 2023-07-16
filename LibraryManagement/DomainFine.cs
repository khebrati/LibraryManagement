namespace Domain;
public struct DomainFine
{
    public string FineId { get; init; }
    public Patron Patron { get; set; }
    public int FineAmount { get; set; }
    public bool PaymentStatus { get; set; }
}