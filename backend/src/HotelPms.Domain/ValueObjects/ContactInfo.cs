namespace HotelPms.Domain.ValueObjects;

public record ContactInfo
{
    public string? PhoneNumber { get; init; }

    public string? EmailAddress { get; init; }

    public Address? Address { get; init; }
}
