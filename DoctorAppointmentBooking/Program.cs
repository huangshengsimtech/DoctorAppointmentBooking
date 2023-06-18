using DoctorAppointmentBooking.Database;
using DoctorAppointmentBooking.Repositories;
using DoctorAppointmentBooking.Services;

namespace DoctorAppointmentBooking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add Database.
            builder.Services.AddBookingDb(builder.Configuration);
            // Add Repositories.
            builder.Services.AddTransient<IDoctorTimeSlotRepository, DoctorTimeSlotRepository>();
            builder.Services.AddTransient<IAppointmentRepository, AppointmentRepository>();
            // Add Services.
            builder.Services.AddTransient<IDoctorTimeSlotService, DoctorTimeSlotService>();
            builder.Services.AddTransient<IAppointmentService, AppointmentService>();
            // Add Controllers.
            builder.Services.AddControllers();

            var app = builder.Build();

            app.MapGet("/", () => "Appointment Booking App (for Doctors and Patients)");
            app.MapControllers();

            app.Run();
        }
    }
}