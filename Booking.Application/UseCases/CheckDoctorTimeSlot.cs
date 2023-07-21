using Management.Shared;
using BookingInquiry.Application.UseCases.Dtos;

namespace BookingInquiry.Application.UseCases
{
    public class CheckDoctorTimeSlot
    {
        private readonly IManagementModuleAPI _managementModuleAPI;

        public CheckDoctorTimeSlot(IManagementModuleAPI managementModuleAPI)
        {
            _managementModuleAPI = managementModuleAPI;
        }
        public async Task<DoctorTimeSlotDto?> Execute(DoctorTimeSlotRequest request)
        {
            return await _managementModuleAPI.GetTimeSlotById(request.SlotId); 
        }
    }
}
