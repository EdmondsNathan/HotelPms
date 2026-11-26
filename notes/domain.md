- Property
    - Name
    - List<Room>
    - List<Employee>
    - List<Reservation>

- Employee
    - Name
        - First
        - Last
    - Union<Role>
        - Manager
        - Housekeeping
        - Desk

- Room
    - List<Reservation>
    - Union<Housekeeping>
        - Dirty
        - Clean
    - List<MaintenanceRecord>

- MaintenanceRecord
    - Room?
    - DateCreated
    - DateResolved?
    - Description

- Reservation
    - DateIn
    - DateOut
    - Guest
    - Union<Status>
        - Upcoming
        - InHouse
        - CheckedOut
        - Cancelled
        - NoShow
    - List<Rate>
    - Room?

- Rate
    - Date
    - Money

- Money
    - Amount
    - Currency

- Guest
    - Name
        - First
        - Last
    - Membership
    - ContactInfo

- Membership
    - Id
    - Union<Tier>
        - Silver
        - Gold
        - Diamond

- ContactInfo
    - PhoneNumber
    - EmailAddress
    - Address

- Address
    - Line1
    - Line2?
    - City
    - Region?
    - PostalCode?
    - Country
