using Microsoft.Extensions.DependencyInjection;
using Booking.Application.UseCases;
using Booking.Domain.Contracts;
using Booking.Infrastructure.Repositories;

namespace Booking
{
    public static class Extensions
    {
        public static IServiceCollection AddBookingModule(this IServiceCollection services)
        {
            services.AddTransient<CreatePatientAppointment>()
                .AddTransient<BookDoctorTimeSlotById>()
                .AddTransient<IPatientAppointmentRepository, PatientAppointmentInMemoryRepo>();
            return services;
        }
    }
}