namespace HotelPms.Domain.ValueObjects;

public class Rate
{
    public required DateOnly Date { get; set; }

    public required Money Money { get; set; }
}
