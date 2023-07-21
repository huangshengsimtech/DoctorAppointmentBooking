using Microsoft.Extensions.DependencyInjection;
using PatientBooking.Application.UseCases;

namespace PatientBooking
{
    public static class Extensions
    {
        public static IServiceCollection AddPatientBookingModule(this IServiceCollection services)
        {
            services.AddTransient<CreatePatientAppointment>();
            return services;
        }
    }
}