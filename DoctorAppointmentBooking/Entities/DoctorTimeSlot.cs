using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentBooking.Entities
{
    public class DoctorTimeSlot
    {
        [Required] public Guid Id { get; set; }
        [Required] public Date Time { get; set; }
        [Required] public Guid DoctorId { get; set; }
        [Required] public string DoctorName { get; set; }
        [Required] public bool IsReserved { get; set; }
        [Required] public decimal Cost { get; set; }
    }
}
