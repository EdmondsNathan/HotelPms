using HotelPms.Domain.Enums;

namespace HotelPms.Domain.Entities;

public class Membership
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public required MembershipTier MembershipTier { get; set; }
}
