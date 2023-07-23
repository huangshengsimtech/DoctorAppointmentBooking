using System.ComponentModel.DataAnnotations;

namespace ManagementInquiry.Application.UseCases.Dtos
{
    public class DoctorTimeSlotRequest
    {
        [Required] public Guid AppointmentId { get; set; }
        [Required] public Guid SlotId { get; set; }
    }
}
