using HotelPms.Domain.Enums;
using HotelPms.Domain.ValueObjects;

namespace HotelPms.Domain.Entities;

public class Reservation
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public required DateOnly DateIn { get; set; }

    public required DateOnly DateOut { get; set; }

    public required Guest Guest { get; set; }

    public ReservationStatus ReservationStatus { get; set; } = ReservationStatus.Upcoming;

    public ICollection<Rate> Rate { get; set; } = [];
}
