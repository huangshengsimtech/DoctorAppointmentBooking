using Management.API.Services;
using Management.Application.UseCases;
using Management.Application.Contracts;
using Management.Domain.Contracts;
using Management.Infrastructure;
using Management.Infrastructure.Repositories;
using Management.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Management.API
{
    public static class Extensions
    {
        public static IServiceCollection AddManagementModule(this IServiceCollection services)
        {
            services
                .AddTransient<CreateDoctorTimeSlot>()
                .AddTransient<GetDoctorTimeSlotById>()
                .AddTransient<GetDoctorTimeSlot>()
                .AddTransient<GetDoctorAvailableTimeSlots>()
                .AddTransient<BookDoctorTimeSlot>()
                .AddTransient<IManagementModuleAPI, ManagementModuleAPI>()
                .AddTransient<ISlotPublisher, RabbitMQSlotPublisher>()
                .AddTransient<IDoctorTimeSlotRepository, DoctorTimeSlotInMemoryRepo>();
            return services;
        }
        public static IApplicationBuilder UseManagementModule(this IApplicationBuilder app)
        {
            return app;
        }


    }
}