using Notification.API.Services;
using Notification.Application.UseCases;
using Notification.Domain.Contracts;
using Notification.Infrastructure.Repositories;
using Notification.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace Notification.API
{
    public static class Extensions
    {
        public static IServiceCollection AddNotificationModule(this IServiceCollection services)
        {
            services
                .AddTransient<CreateAppointmentConfirmationShared>()
                .AddTransient<IAppointmentConfirmationRepository, AppointmentConfirmationInMemoryRepo>()
                .AddTransient<INotificationModuleAPI, NotificationModuleAPI>();
            return services;
        }

        public static IApplicationBuilder UseNotificationModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}