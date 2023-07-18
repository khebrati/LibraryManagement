namespace Domain;
public struct Fine
{
    public string FineId { get; init; }
    public int FineAmount { get; set; }
    public bool PaymentStatus { get; set; }
}