using System.ComponentModel.DataAnnotations;

namespace PatientBooking.Controllers.Dtos
{
    public class CreatePatientAppointmentRequest
    {
        [Required] public Guid Id { get; set; }
        [Required] public Guid SlotId { get; set; }
        [Required] public Guid PatientId { get; set; }
        [Required] public string PatientName { get; set; }
        [Required] public DateTime ReservedAt { get; set; }
    }
}
