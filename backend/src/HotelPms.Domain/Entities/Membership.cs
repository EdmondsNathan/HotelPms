using HotelPms.Domain.Enums;

namespace HotelPms.Domain.Entities;

public class Membership
{
    public Guid Id { get; private set; }

    public MembershipTier MembershipTier { get; private set; }

    private Membership() { } // Used by EF Core

    public Membership(MembershipTier membershipTier)
    {
        if (!Enum.IsDefined(membershipTier))
        {
            throw new ArgumentOutOfRangeException(nameof(membershipTier));
        }

        Id = Guid.NewGuid();
        MembershipTier = membershipTier;
    }
}
