namespace HotelPms.Domain.ValueObjects;

public record Rate
{
    public required DateOnly Date { get; init; }

    public required Money Money { get; init; }
}
