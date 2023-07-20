using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.UseCases.Dtos
{
    public class BookSlotRequest
    {
        [Required] public Guid AppointmentId { get; set; }
        [Required] public Guid SlotId { get; set; }
    }
}
