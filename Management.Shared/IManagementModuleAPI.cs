using Management.Domain.Entities;

namespace Management.Shared
{
    public interface IManagementModuleAPI
    {
        public Task<List<DoctorTimeSlot>> GetTimeSlotsByDoctorId(Guid doctorId);
        public Task<List<DoctorTimeSlot>> GetAvailableTimeSlots();
        public Task ReserveTimeSlot(Guid id);
    }

    public record DoctorTimeSlotDto(
        Guid Id,
        DateTime Time,
        Guid DoctorId,
        string DoctorName,
        bool IsReserved,
        decimal Cost
    );
}
