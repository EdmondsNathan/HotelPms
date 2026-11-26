using HotelPms.Domain.Enums;

namespace HotelPms.Domain.Entities;

public class Employee
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required EmployeeRole Role { get; set; }
}
