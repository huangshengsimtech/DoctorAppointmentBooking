using System.ComponentModel.DataAnnotations;

namespace Booking.Application.UseCases.Dtos
{
    public class BookSlotRequest
    {
        [Required] public Guid AppointmentId { get; set; }
        [Required] public Guid SlotId { get; set; }
    }
}
