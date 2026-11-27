using HotelPms.Domain.Enums;

namespace HotelPms.Domain.Entities;

public class Employee
{
    public Guid Id { get; private set; }

    public string FirstName { get; private set; } = null!;

    public string LastName { get; private set; } = null!;

    public EmployeeRole EmployeeRole { get; private set; }

    private Employee() { } // Used by EF Core

    public Employee(string firstName, string lastName, EmployeeRole employeeRole)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(firstName);
        ArgumentException.ThrowIfNullOrWhiteSpace(lastName);
        if (!Enum.IsDefined(employeeRole))
        {
            throw new ArgumentOutOfRangeException(nameof(employeeRole));
        }

        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        EmployeeRole = employeeRole;
    }
}
