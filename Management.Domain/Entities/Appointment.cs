using System.ComponentModel.DataAnnotations;

namespace Management.Domain.Entities
{
    public class Appointment
    {
        [Required] public Guid Id { get; set; }
        [Required] public Guid SlotId { get; set; }
        [Required] public Guid PatientId { get; set; }
        [Required] public string PatientName { get; set; }
        [Required] public DateTime ReservedAt { get; set; }
    }
}
