using HotelPms.Domain.ValueObjects;

namespace HotelPms.Domain.Entities;

public class Guest
{
    public Guid Id { get; private set; }

    public string FirstName { get; private set; } = null!;

    public string LastName { get; private set; } = null!;

    public Membership? Membership { get; private set; }

    public ContactInfo ContactInfo { get; private set; } = null!;

    private Guest() { } // Used by EF Core

    public Guest(string firstName, string lastName, ContactInfo contactInfo, Membership? membership = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(firstName);
        ArgumentException.ThrowIfNullOrWhiteSpace(lastName);
        ArgumentNullException.ThrowIfNull(contactInfo);

        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        ContactInfo = contactInfo;
        Membership = membership;
    }

    public void AssignMembership(Membership membership)
    {
        ArgumentNullException.ThrowIfNull(membership);

        Membership = membership;
    }

    public void RemoveMembership()
    {
        Membership = null;
    }
}
