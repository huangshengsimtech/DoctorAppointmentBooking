using DoctorAppointmentBookingLayered.Entities;

namespace DoctorAppointmentBookingLayered.Services
{
    public interface IDoctorTimeSlotServiceLayered
    {
        public Task Create(DoctorTimeSlotLayered doctorTimeSlot);
        public Task<List<DoctorTimeSlotLayered>> GetTimeSlotsByDoctorId(Guid doctorId);
        public Task<List<DoctorTimeSlotLayered>> GetAvailableTimeSlots();
        public Task ReserveTimeSlot(Guid id);
    }
}
