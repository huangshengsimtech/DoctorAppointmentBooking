using Management.Domain.Entities;

namespace Management.Shared
{
    public interface IDoctorTimeSlotService
    {
        public Task Create(DoctorTimeSlot doctorTimeSlot);
        public Task<List<DoctorTimeSlot>> GetTimeSlotsByDoctorId(Guid doctorId);
        public Task<List<DoctorTimeSlot>> GetAvailableTimeSlots();
        public Task ReserveTimeSlot(Guid id);
    }
}
