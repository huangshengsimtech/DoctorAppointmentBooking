using Authentication.API;
using Management.API;
using ManagementInquiry.API;
using Booking;
using Notification.API;
using Serilog;
using Microsoft.AspNetCore.HttpLogging;

namespace DoctorAppointmentBooking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Host.UseSerilog((context, services, configuration) =>
            {
                configuration
                    .ReadFrom.Configuration(context.Configuration)
                    .ReadFrom.Services(services);
            });
            builder.Services.AddHttpLogging(options =>
            {
                options.LoggingFields = HttpLoggingFields.All;
            });

            builder.Services
                .AddAuthenticationModule(builder.Configuration)
                .AddManagementModule()
                .AddManagementInquiryModule()
                .AddBookingModule()
                .AddNotificationModule();

            builder.Services.AddControllers();

            var app = builder.Build();
            app.UseHttpLogging();

            Log.Information("Serilog started!");

            app.MapGet("/", () => "Appointment Booking App (for Doctors and Patients)");
            app.MapControllers();

            app.Run();
        }
    }
}