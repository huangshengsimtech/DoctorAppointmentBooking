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
            services
                .AddTransient<BookDoctorTimeSlotById>()
                .AddTransient<BookDoctorTimeSlotByIdLayered>()
                .AddTransient<CreatePatientAppointment>()
                .AddTransient<GetBookedDoctorTimeSlotById>()
                .AddTransient<GetBookedDoctorTimeSlotByIdLayered>()
                .AddTransient<SendAppointmentConfirmationNotification>()
                .AddTransient<SendAppointmentConfirmationNotificationLayered>()
                .AddTransient<IPatientAppointmentRepository, PatientAppointmentInMemoryRepo>();
            return services;
        }
    }
}