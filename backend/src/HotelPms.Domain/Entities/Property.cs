namespace HotelPms.Domain.Entities;

public class Property
{
    public Guid Id { get; private set; }

    public string Name { get; private set; } = null!;

    public ICollection<Room> Rooms { get; private set; } = [];

    public ICollection<Employee> Employees { get; private set; } = [];

    public ICollection<Reservation> Reservations { get; private set; } = [];

    private Property() { } // Used by EF Core

    public Property(string name, ICollection<Room>? rooms = null, ICollection<Employee>? employees = null, ICollection<Reservation>? reservations = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        Id = Guid.NewGuid();
        Name = name;
        Rooms = rooms?.ToList() ?? [];
        Employees = employees?.ToList() ?? [];
        Reservations = reservations?.ToList() ?? [];
    }
}
