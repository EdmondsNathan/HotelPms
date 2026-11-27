using HotelPms.Domain.Enums;
using HotelPms.Domain.ValueObjects;

namespace HotelPms.Domain.Entities;

public class Reservation
{
    public Guid Id { get; private set; }

    public DateOnly DateIn { get; private set; }

    public DateOnly DateOut { get; private set; }

    public Guest Guest { get; private set; } = null!;

    public ReservationStatus ReservationStatus { get; private set; }

    public ICollection<Rate> Rates { get; private set; } = [];

    private Reservation() { } // Used by EF Core

    public Reservation(DateOnly dateIn, DateOnly dateOut, Guest guest, ReservationStatus reservationStatus, ICollection<Rate> rates)
    {
        ArgumentNullException.ThrowIfNull(guest);
        ArgumentNullException.ThrowIfNull(rates);
        if (dateOut < dateIn)
        {
            throw new ArgumentException("Date Out cannot be earlier than Date In.", nameof(dateOut));
        }
        if (!Enum.IsDefined(reservationStatus))
        {
            throw new ArgumentOutOfRangeException(nameof(reservationStatus));
        }
        ValidateRates(dateIn, dateOut, rates);

        Id = Guid.NewGuid();
        DateIn = dateIn;
        DateOut = dateOut;
        Guest = guest;
        ReservationStatus = reservationStatus;
        Rates = [.. rates];
    }

    private static void ValidateRates(DateOnly dateIn, DateOnly dateOut, ICollection<Rate> rates)
    {
        var rateCount = dateOut == dateIn ? 1 : dateOut.DayNumber - dateIn.DayNumber;

        if (rates.Count != rateCount)
        {
            throw new ArgumentException("There must be exactly one rate per date.", nameof(rates));
        }

        if (rates.Any(rate => rate is null))
        {
            throw new ArgumentException("Rates cannot contain null elements.", nameof(rates));
        }

        var dates = Enumerable.Range(0, rateCount).Select(dateIn.AddDays).ToHashSet();

        if (rates.Select(rate => rate.Date).Distinct().Count() != rates.Count)
        {
            throw new ArgumentException("There must not be duplicate rate dates.", nameof(rates));
        }

        if(!rates.All(rate => dates.Contains(rate.Date)))
        {
            throw new ArgumentException("There must be a rate for every date.", nameof(rates));
        }
    }
}
