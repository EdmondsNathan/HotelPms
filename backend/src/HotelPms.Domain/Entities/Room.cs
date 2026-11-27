using HotelPms.Domain.Enums;

namespace HotelPms.Domain.Entities;

public class Room
{
    public Guid Id { get; private set; }

    public ICollection<Reservation> Reservations { get; private set; } = [];

    public HousekeepingStatus HousekeepingStatus { get; private set; }

    public ICollection<MaintenanceRecord> MaintenanceRecords { get; private set; } = [];

    public RoomType RoomType { get; private set; } = null!;

    private Room() { } // Used by EF Core

    public Room(HousekeepingStatus housekeepingStatus, RoomType roomType, ICollection<Reservation>? reservations = null, ICollection<MaintenanceRecord>? maintenanceRecords = null)
    {
       ArgumentNullException.ThrowIfNull(roomType);
       if (!Enum.IsDefined(housekeepingStatus))
       {
           throw new ArgumentOutOfRangeException(nameof(housekeepingStatus));
       }

        Id = Guid.NewGuid();
        HousekeepingStatus = housekeepingStatus;
        RoomType = roomType;
        Reservations = reservations?.ToList() ?? [];
        MaintenanceRecords = maintenanceRecords?.ToList() ?? [];
    }
}
