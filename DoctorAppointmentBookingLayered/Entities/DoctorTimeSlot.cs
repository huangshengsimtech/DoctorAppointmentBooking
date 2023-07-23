using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentBookingLayered.Entities
{
    public class DoctorTimeSlot
    {
        [Required] public Guid Id { get; set; }
        [Required] public DateTime Time { get; set; }
        [Required] public Guid DoctorId { get; set; }
        [Required] public string DoctorName { get; set; }
        [Required] public bool IsReserved { get; set; }
        [Required][Range(0.0, 1000000000.0)] public decimal Cost { get; set; }
    }
}
