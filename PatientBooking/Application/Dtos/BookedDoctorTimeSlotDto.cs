
namespace Booking.Application.Dtos
{
    public record BookedDoctorTimeSlotDto(
        Guid Id,
        DateTime Time,
        Guid DoctorId,
        string DoctorName,
        bool IsReserved,
        decimal Cost
    );
}
