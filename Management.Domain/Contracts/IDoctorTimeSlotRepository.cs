using Management.Domain.Entities;

namespace Management.Domain.Contracts
{
    public interface IDoctorTimeSlotRepository
    {
        public Task Add(DoctorTimeSlot doctorTimeSlot);
        public Task<DoctorTimeSlot?> GetById(Guid id);
        public Task<List<DoctorTimeSlot>> GetByDoctorIdAsync(Guid doctorId);
        public Task<List<DoctorTimeSlot>> GetAvailableTimeSlotsAsync();
        public Task UpdateDoctorTimeSlotReservedStatus(Guid id);
        Task<bool> DoesTimeSlotExist(DateTime time);
    }
}
