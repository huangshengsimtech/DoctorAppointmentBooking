using Microsoft.Extensions.DependencyInjection;
using Booking.Application.UseCases;

namespace Booking.API
{
    public static class Extensions
    {
        public static IServiceCollection AddBookingModule(this IServiceCollection services)
        {
            services.AddTransient<BookSlot>();
            return services;
        }
    }
}