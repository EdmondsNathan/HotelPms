namespace HotelPms.Domain.Entities;

public class Property 
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public required string Name { get; set; }

    public ICollection<Room> Rooms { get; set; } = [];

    public ICollection<Employee> Employees { get; set; } = [];

    public ICollection<Reservation> Reservations { get; set; } = [];
}
