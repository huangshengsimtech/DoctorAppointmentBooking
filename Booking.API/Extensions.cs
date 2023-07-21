using Microsoft.Extensions.DependencyInjection;
using BookingInquiry.Application.UseCases;

namespace BookingInquiry.API
{
    public static class Extensions
    {
        public static IServiceCollection AddBookingInquiryModule(this IServiceCollection services)
        {
            services.AddTransient<CheckDoctorTimeSlot>();
            return services;
        }
    }
}