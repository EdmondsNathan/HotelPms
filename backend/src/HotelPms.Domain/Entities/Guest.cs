namespace HotelPms.Domain.Entities;

public class Guest
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public required string FirstName;

    public required string LastName;
    
    public Membership? Membership;

    public required ContactInfo ContactInfo;
}
