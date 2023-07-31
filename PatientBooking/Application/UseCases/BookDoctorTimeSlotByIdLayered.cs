using DoctorAppointmentBookingLayered.Shared;

namespace Booking.Application.UseCases
{
    public class BookDoctorTimeSlotByIdLayered
    {
        private readonly IManagementModuleAPILayered _managementModuleAPI;

        public BookDoctorTimeSlotByIdLayered(IManagementModuleAPILayered managementModuleAPI)
        {
            _managementModuleAPI = managementModuleAPI;
        }
        public async Task Execute(Guid id)
        {
            await _managementModuleAPI.ReserveTimeSlot(id);
        }
    }
}
