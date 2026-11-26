namespace HotelPms.Domain.Entities;

public class MaintenanceRecord
{
    public required Guid Id { get; set; }

    public Room? Room;
    
    public required DateOnly DateCreated;

    public DateOnly? DateResolved;
    
    public required string Description;
}
