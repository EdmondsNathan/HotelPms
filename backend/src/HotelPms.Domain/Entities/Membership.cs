using HotelPms.Domain.Enums;

namespace HotelPms.Domain.Entities;

public class Membership
{
    public required Guid Id { get; set; }

    public required MembershipTier MembershipTier { get; set; }
}
