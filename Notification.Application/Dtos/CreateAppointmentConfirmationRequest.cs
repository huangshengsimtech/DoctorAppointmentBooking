using System.ComponentModel.DataAnnotations;

namespace Notification.Application.Dtos
{
    public class CreateAppointmentConfirmationRequest
    {
        [Required] public Guid SlotId { get; set; }
        [Required] public Guid DoctorId { get; set; }
        [Required] public Guid PatientId { get; set; }
        [Required] public string DoctorName { get; set; }
        [Required] public string PatientName { get; set; }
        [Required] public DateTime Time { get; set; }
    }
}
