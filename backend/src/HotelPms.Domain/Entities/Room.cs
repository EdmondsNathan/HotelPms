using HotelPms.Domain.Enums;

namespace HotelPms.Domain.Entities;

public class Room
{
    public required Guid Id { get; set; }

    public required ICollection<Reservation> Reservations { get; set; }

    public required HousekeepingStatus HousekeepingStatus { get; set; }

    public required ICollection<MaintenanceRecord> MaintenanceRecords { get; set; }

    public required RoomType RoomType { get; set; }
}
