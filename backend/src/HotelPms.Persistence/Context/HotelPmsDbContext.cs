using HotelPms.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelPms.Persistence.Context;

public class HotelPmsDbContext(DbContextOptions<HotelPmsDbContext> options) : DbContext(options)
{
    public DbSet<Guest> Guests => Set<Guest>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Property> Properties => Set<Property>();
    public DbSet<Room> Rooms => Set<Room>();
    public DbSet<RoomType> RoomTypes => Set<RoomType>();
    public DbSet<Reservation> Reservations => Set<Reservation>();
    public DbSet<Membership> Memberships => Set<Membership>();
    public DbSet<MaintenanceRecord> MaintenanceRecords => Set<MaintenanceRecord>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HotelPmsDbContext).Assembly);
    }
}
