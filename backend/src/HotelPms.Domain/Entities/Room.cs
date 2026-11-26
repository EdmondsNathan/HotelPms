using HotelPms.Domain.Enums;

namespace HotelPms.Domain.Entities;

public class Room
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public ICollection<Reservation> Reservations { get; set; } = [];

    public HousekeepingStatus HousekeepingStatus { get; set; } = HousekeepingStatus.Clean;

    public ICollection<MaintenanceRecord> MaintenanceRecords { get; set; } = [];
}
