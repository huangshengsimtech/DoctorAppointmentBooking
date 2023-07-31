namespace DoctorAppointmentBookingLayered.Shared
{
    public interface IManagementModuleAPILayered
    {
        public Task ReserveTimeSlot(Guid id);
        Task<DoctorTimeSlotDtoLayered?> GetTimeSlotById(Guid id);
    }

    public record DoctorTimeSlotDtoLayered(
        Guid Id,
        DateTime Time,
        Guid DoctorId,
        string DoctorName,
        bool IsReserved,
        decimal Cost
    );
}
