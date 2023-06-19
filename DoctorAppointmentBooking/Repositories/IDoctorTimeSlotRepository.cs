using DoctorAppointmentBooking.Entities;

namespace DoctorAppointmentBooking.Repositories
{
    public interface IDoctorTimeSlotRepository
    {
        public Task Add(DoctorTimeSlot doctorTimeSlot);
        public Task<List<DoctorTimeSlot>> GetByDoctorIdAsync(Guid doctorId);
        public Task<List<DoctorTimeSlot>> GetAvailableTimeSlotsAsync();
        public Task UpdateDoctorTimeSlotReservedStatus(Guid id);
    }
}
