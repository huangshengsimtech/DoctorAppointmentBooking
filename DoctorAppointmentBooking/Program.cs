using DoctorAppointmentBooking.Repositories;
using DoctorAppointmentBooking.Services;

namespace DoctorAppointmentBooking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<IDoctorTimeSlotRepository, DoctorTimeSlotRepository>();
            builder.Services.AddTransient<IDoctorTimeSlotService, DoctorTimeSlotService>();

            builder.Services.AddTransient<IAppointmentRepository, AppointmentRepository>();
            builder.Services.AddTransient<IAppointmentService, AppointmentService>();

            builder.Services.AddControllers();

            var app = builder.Build();

            app.MapGet("/", () => "Appointment Booking App (for Doctors and Patients)");
            app.MapControllers();

            app.Run();
        }
    }
}