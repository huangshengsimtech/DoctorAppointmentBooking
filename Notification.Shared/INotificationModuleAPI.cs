namespace Notification.Shared
{
    public interface INotificationModuleAPI
    {
        Task CreateNotification(AppointmentConfirmationDto appointmentConfirmationDto);
    }

    public record AppointmentConfirmationDto(
        Guid SlotId,
        Guid DoctorId,
        Guid PatientId,
        string DoctorName,
        string PatientName,
        DateTime Time
    );
}