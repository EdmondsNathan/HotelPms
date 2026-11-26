using HotelPms.Domain.Enums;
using HotelPms.Domain.ValueObjects;

namespace HotelPms.Domain.Entities;

public class Reservation
{
    public required Guid Id { get; set; }

    public required DateOnly DateIn { get; set; }

    public required DateOnly DateOut { get; set; }

    public required Guest Guest { get; set; }

    public required ReservationStatus ReservationStatus { get; set; }

    public required ICollection<Rate> Rate { get; set; }
}
