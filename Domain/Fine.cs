namespace Domain;
public struct Fine
{
    public int FineId { get; init; }
    public Patron Patron { get; set; }
    public int FineAmount { get; set; }
    public bool PaymentStatus { get; set; }
}