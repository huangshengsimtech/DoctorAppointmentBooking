using DoctorAppointmentBookingLayered.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace DoctorAppointmentBookingLayered.Database
{
    public class BookingDatabase : DbContext
    {
        public DbSet<DoctorTimeSlot> DoctorTimeSlots { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public BookingDatabase(DbContextOptions<BookingDatabase> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
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
