using DoctorAppointmentBookingLayered.Entities;

namespace DoctorAppointmentBookingLayered.Repositories
{
    public interface IDoctorTimeSlotRepository
    {
        public Task Add(DoctorTimeSlot doctorTimeSlot);
        public Task<List<DoctorTimeSlot>> GetByDoctorIdAsync(Guid doctorId);
        public Task<List<DoctorTimeSlot>> GetAvailableTimeSlotsAsync();
        public Task UpdateDoctorTimeSlotReservedStatus(Guid id);
        Task<bool> DoesTimeSlotExist(DateTime time);
    }
}
