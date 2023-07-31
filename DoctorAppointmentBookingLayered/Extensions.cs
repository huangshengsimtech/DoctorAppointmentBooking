using DoctorAppointmentBookingLayered.Repositories;
using DoctorAppointmentBookingLayered.Services;
using DoctorAppointmentBookingLayered.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorAppointmentBookingLayered
{
    public static class Extensions
    {
        public static IServiceCollection AddDoctorAppointmentBookingLayeredModule(this IServiceCollection services)
        {
            services
                .AddTransient<IDoctorTimeSlotInMemoryRepoLayered, DoctorTimeSlotInMemoryRepoLayered>()
                .AddTransient<IManagementModuleAPILayered, ManagementModuleAPILayered>()
                .AddTransient<IDoctorTimeSlotServiceLayered, DoctorTimeSlotServiceLayered>();
            return services;
        }
    }
}