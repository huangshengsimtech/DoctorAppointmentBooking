using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Application.Dtos
{
    public class CreateDoctorTimeSlotRequest
    {
        [Required] public Guid Id { get; set; }
        [Required] public DateTime Time { get; set; }
        [Required] public Guid DoctorId { get; set; }
        [Required] public string DoctorName { get; set; }
        [Required] public bool IsReserved { get; set; }
        [Required][Range(0.0, 1000000000.0)] public decimal Cost { get; set; }
    }
}
