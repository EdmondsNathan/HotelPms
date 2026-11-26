namespace HotelPms.Domain.Entities;

public class Property 
{
    public required Guid Id { get; set; }
    
    public required string Name { get; set; }

    public required ICollection<Room> Rooms { get; set; }

    public required ICollection<Employee> Employees { get; set; }

    public required ICollection<Reservation> Reservations { get; set; }
}
