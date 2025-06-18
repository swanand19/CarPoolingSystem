using CarPoolingSystem.Tables;
using Microsoft.EntityFrameworkCore;

namespace CarPoolingSystem.DbEntities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) { }

        public DbSet<Ride> Rides { get; set; }
        public DbSet<RideBooking> RideBookings { get; set; }
        public DbSet<RideRoute> RideRoutes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<UserDocument> UserDocuments { get; set; }
    }
}
