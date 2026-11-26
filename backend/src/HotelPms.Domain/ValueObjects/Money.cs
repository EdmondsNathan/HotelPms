namespace HotelPms.Domain.ValueObjects;

public class Money
{
    public required decimal Amount { get; set; }

    public required string Currency { get; set; }
}
