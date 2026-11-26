using HotelPms.Domain.ValueObjects;

namespace HotelPms.Domain.Entities;

public class Guest
{
    public required Guid Id { get; set; }

    public required string FirstName;

    public required string LastName;
    
    public Membership? Membership;

    public required ContactInfo ContactInfo;
}
