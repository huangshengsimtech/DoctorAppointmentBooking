using Authentication.API;
using Management.API;
using Booking.API;


namespace DoctorAppointmentBooking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services
                .AddAuthenticationModule(builder.Configuration)
                .AddManagementModule();
            //builder.Services
            //    .AddManagementModule()
            //    .AddAuthenticationModule(builder.Configuration)
            //    .AddBookingModule();

            builder.Services.AddControllers();

            var app = builder.Build();

            app.MapGet("/", () => "Appointment Booking App (for Doctors and Patients)");
            app.MapControllers();

            app.Run();
        }
    }
}