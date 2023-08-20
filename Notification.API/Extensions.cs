using Convey.MessageBrokers.RabbitMQ;
using Management.Shared.Events;
using Notification.Application;
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
            services.AddApplication();

            return services;
        }

        public static IApplicationBuilder UseNotificationModule(this IApplicationBuilder app)
        {
            app.UseRabbitMq().Subscribe<SchedulingAnAppointmentEventDto>(async (serviceProvider, message, context) =>
            {
                await serviceProvider.GetRequiredService<CreateAppointmentConfirmationEventHandler>().Handle(message);
            });

            return app;
        }
    }
}