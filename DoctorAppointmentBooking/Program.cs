namespace DoctorAppointmentBooking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Appointment Booking App (for Doctors and Patients)");

            app.Run();
        }
    }
}