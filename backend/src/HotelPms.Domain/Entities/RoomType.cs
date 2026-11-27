namespace HotelPms.Domain.Entities;

public class RoomType
{
    public Guid Id { get; private set; }

    public string Name { get; private set; } = null!;

    public string Description { get; private set; } = null!;

    public int MaxOccupancy { get; private set; }

    private RoomType() { } // Used by EF Core

    public RoomType(string name, string description, int maxOccupancy)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(description);
        ArgumentOutOfRangeException.ThrowIfNegative(maxOccupancy);

        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        MaxOccupancy = maxOccupancy;
    }
}
