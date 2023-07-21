using Management.Shared;
using Booking.Application.UseCases.Dtos;

namespace Booking.Application.UseCases
{
    public class BookSlot
    {
        private readonly IManagementModuleAPI _managementModuleAPI;

        public BookSlot(IManagementModuleAPI managementModuleAPI)
        {
            _managementModuleAPI = managementModuleAPI;
        }
        public async Task<DoctorTimeSlotDto?> Execute(BookSlotRequest request)
        {
            return await _managementModuleAPI.GetTimeSlotById(request.SlotId); 
        }
    }
}
