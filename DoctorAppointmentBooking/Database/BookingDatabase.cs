using DoctorAppointmentBooking.Entities;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointmentBooking.Database
{
    public class BookingDatabase : DbContext
    {
        public DbSet<DoctorTimeSlot> DoctorTimeSlots { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public BookingDatabase(DbContextOptions<BookingDatabase> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("booking_db");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
    public static class DbExtension
    {
        public static IServiceCollection AddBookingDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookingDatabase>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("Postgres"));
            });
            return services;
        }
    }
}
