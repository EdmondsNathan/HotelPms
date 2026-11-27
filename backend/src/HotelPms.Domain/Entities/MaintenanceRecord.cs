namespace HotelPms.Domain.Entities;

public class MaintenanceRecord
{
    public Guid Id { get; private set; }

    public Room? Room { get; private set; }
    
    public DateOnly? ScheduledDate { get; private set; }

    public DateOnly? DateResolved { get; private set; }
    
    public string Description { get; private set; } = null!;

    private MaintenanceRecord() { } // Used by EF Core

    public MaintenanceRecord(string description, DateOnly? scheduledDate = null, DateOnly? dateResolved = null, Room? room = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(description);

        Id = Guid.NewGuid();
        Description = description;
        ScheduledDate = scheduledDate;
        DateResolved = dateResolved;
        Room = room;
    }
}
