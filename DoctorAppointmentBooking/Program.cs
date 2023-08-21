using Authentication.API;
using DoctorAppointmentBookingLayered;
using Management.API;
using ManagementInquiry.API;
using Booking;
using Notification.API;
using Serilog;
using Microsoft.AspNetCore.HttpLogging;
using Convey.MessageBrokers.RabbitMQ;
using Convey;

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
                .AddDoctorAppointmentBookingLayeredModule()
                .AddManagementModule()
                .AddManagementInquiryModule()
                .AddBookingModule()
                .AddNotificationModule();

            builder.Services.AddConvey().AddRabbitMq();

            builder.Services.AddControllers();

            var app = builder.Build();
            //app.UseNotificationModule();

            app.UseHttpLogging();

            Log.Information("Serilog started!");

            app.MapGet("/", () => "Appointment Booking App (for Doctors and Patients)");
            app.MapControllers();

            app.Run();
        }
    }
}