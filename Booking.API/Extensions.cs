using Microsoft.Extensions.DependencyInjection;
using ManagementInquiry.Application.UseCases;

namespace ManagementInquiry.API
{
    public static class Extensions
    {
        public static IServiceCollection AddManagementInquiryModule(this IServiceCollection services)
        {
            services.AddTransient<CheckDoctorTimeSlot>();
            return services;
        }
    }
}