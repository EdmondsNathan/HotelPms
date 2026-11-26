namespace HotelPms.Domain.Entities;

public class MaintenanceRecord
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Room? Room;
    
    public required DateOnly DateCreated;

    public DateOnly? DateResolved;
    
    public required string Description;
}
