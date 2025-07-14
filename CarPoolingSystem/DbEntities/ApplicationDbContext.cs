using CarPoolingSystem.Tables;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarPoolingSystem.DbEntities
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, long>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) { }

        public DbSet<Ride> Rides { get; set; }
        public DbSet<RideBooking> RideBookings { get; set; }
        public DbSet<RideRoute> RideRoutes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<UserDocument> UserDocuments { get; set; }
    }
}
