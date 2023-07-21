using System.ComponentModel.DataAnnotations;

namespace BookingInquiry.Application.UseCases.Dtos
{
    public class DoctorTimeSlotRequest
    {
        [Required] public Guid AppointmentId { get; set; }
        [Required] public Guid SlotId { get; set; }
    }
}
