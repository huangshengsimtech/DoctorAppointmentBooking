namespace Management.Shared
{
    public interface IManagementModuleAPI
    {
        public Task ReserveTimeSlot(Guid id);
        Task<DoctorTimeSlotDto?> GetTimeSlotById(Guid id);
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
