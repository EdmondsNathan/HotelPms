namespace HotelPms.Domain.ValueObjects;

public record Address
{
    public required string Line1 { get; init; }

    public string? Line2 { get; init; }

    public required string City { get; init; }

    public string? Region { get; init; }

    public string? PostalCode { get; init; }

    public required string Country { get; init; }
}
