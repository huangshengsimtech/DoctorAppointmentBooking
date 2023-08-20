using Microsoft.Extensions.DependencyInjection;
using Notification.Application.UseCases;

namespace Notification.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<CreateAppointmentConfirmationEventHandler>();
            return services;
        }
    }


}
