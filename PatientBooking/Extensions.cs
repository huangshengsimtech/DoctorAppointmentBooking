using Microsoft.Extensions.DependencyInjection;
using PatientBooking.Application.UseCases;
using PatientBooking.Domain.Contracts;
using PatientBooking.Infrastructure.Repositories;

namespace PatientBooking
{
    public static class Extensions
    {
        public static IServiceCollection AddPatientBookingModule(this IServiceCollection services)
        {
            services.AddTransient<CreatePatientAppointment>()
                .AddTransient<IPatientAppointmentRepository, PatientAppointmentInMemoryRepo>();
            return services;
        }
    }
}