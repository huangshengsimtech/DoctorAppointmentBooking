using DoctorAppointmentBookingLayered.Services;

namespace DoctorAppointmentBookingLayered.Shared
{
    public class ManagementModuleAPILayered : IManagementModuleAPILayered
    {
        private readonly IDoctorTimeSlotServiceLayered _doctorTimeSlotService;

        public ManagementModuleAPILayered(IDoctorTimeSlotServiceLayered doctorTimeSlotService)
        {
            _doctorTimeSlotService = doctorTimeSlotService;
        }

        public async Task ReserveTimeSlot(Guid id)
        {
            await _doctorTimeSlotService.ReserveTimeSlot(id);

        }
        public async Task<DoctorTimeSlotDtoLayered?> GetTimeSlotById(Guid id)
        {
            var doctorTimeSlot = await _doctorTimeSlotService.GetTimeSlotById(id);

            if (doctorTimeSlot == null) return null;
            return new DoctorTimeSlotDtoLayered(
                doctorTimeSlot.Id,
                doctorTimeSlot.Time,
                doctorTimeSlot.DoctorId,
                doctorTimeSlot.DoctorName,
                doctorTimeSlot.IsReserved,
                doctorTimeSlot.Cost
            );
        }
    }
}
