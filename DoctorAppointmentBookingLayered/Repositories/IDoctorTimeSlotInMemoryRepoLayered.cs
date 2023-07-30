using DoctorAppointmentBookingLayered.Entities;

namespace DoctorAppointmentBookingLayered.Repositories
{
    public interface IDoctorTimeSlotInMemoryRepoLayered
    {
        public Task Add(DoctorTimeSlotLayered doctorTimeSlot);
        public Task<DoctorTimeSlotLayered?> GetById(Guid id);
        public Task<List<DoctorTimeSlotLayered>> GetByDoctorIdAsync(Guid doctorId);
        public Task<List<DoctorTimeSlotLayered>> GetAvailableTimeSlotsAsync();
        public Task UpdateDoctorTimeSlotReservedStatus(Guid id);
        Task<bool> DoesTimeSlotExist(DateTime time);
    }
}
