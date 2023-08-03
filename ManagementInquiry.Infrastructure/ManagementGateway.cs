using Management.Shared;
using ManagementInquiry.Application.UseCases.Dtos;

namespace ManagementInquiry.Infrastructure
{
    public class ManagementGateway
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
