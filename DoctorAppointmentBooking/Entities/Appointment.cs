using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentBooking.Entities
{
    public class Appointment
    {
        [Required] public Guid Id { get; set; }
        [Required] public Guid SlotId { get; set; }
        [Required] public Guid PatientId { get; set; }
        [Required] public string PatientName { get; set; }
        [Required] public Date ReservedAt { get; set; }
    }
}
