namespace HotelPms.Domain.ValueObjects;

public class Address
{
    public required string Line1 { get; set; }

    public string? Line2 { get; set; }

    public required string City { get; set; }
    
    public string? Region { get; set; }

    public string? PostalCode { get; set; }

    public required string Country { get; set; }
}
