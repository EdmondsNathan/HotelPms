- Property
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
    - Room
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
    - Amount

- Guest
    - Name
        - First
        - Last
    - Address
    - Membership
    - ContactInfo

- ContactInfo
    - PhoneNumber

- Address
    - Line1
    - Line2?
    - City
    - Region?
    - PostalCode?
    - Country
