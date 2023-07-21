using Management.Shared;

namespace Booking.Application.UseCases
{
    public class BookDoctorTimeSlotById
    {
        private readonly IManagementModuleAPI _managementModuleAPI;

        public BookDoctorTimeSlotById(IManagementModuleAPI managementModuleAPI)
        {
            _managementModuleAPI = managementModuleAPI;
        }
        public async Task Execute(Guid id)
        {
            await _managementModuleAPI.ReserveTimeSlot(id);
        }
    }
}
