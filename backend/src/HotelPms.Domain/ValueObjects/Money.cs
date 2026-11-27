namespace HotelPms.Domain.ValueObjects;

public record Money
{
    public required decimal Amount { get; init; }

    public required string Currency { get; init; }
}
