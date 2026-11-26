namespace HotelPms.Domain.ValueObjects;

public class ContactInfo
{
    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public Address? Address { get; set; }
}
