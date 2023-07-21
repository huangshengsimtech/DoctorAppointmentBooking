namespace Notification.Shared
{
    public interface INotificationModuleAPI
    {
        Task<DoctorTimeSlotDto?> NotifyReservedTimeSlotById(Guid id);
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