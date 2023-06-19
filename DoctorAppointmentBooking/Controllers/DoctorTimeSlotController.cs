using Microsoft.AspNetCore.Mvc;
using DoctorAppointmentBooking.Entities;
using DoctorAppointmentBooking.Services;

namespace DoctorAppointmentBooking.Controllers
{
    [Controller]
    [Route("/doctortimeslots")]
    public class DoctorTimeSlotController : ControllerBase
    {
        private readonly IDoctorTimeSlotService _doctorTimeSlotService;

        public DoctorTimeSlotController(IDoctorTimeSlotService doctorTimeSlotService)
        {
            _doctorTimeSlotService = doctorTimeSlotService;
        }
        [HttpPost("create")]
        public async Task<IActionResult> Post([FromBody] DoctorTimeSlot doctorTimeSlot)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(value => value.Errors)
                    .Select(error => error.ErrorMessage)
                    .ToList();
                return BadRequest(errors);
            }

            await _doctorTimeSlotService.Create(doctorTimeSlot);
            return Ok("Doctor Time Slot Created..");
        }
        [HttpGet("available")]
        public async Task<IActionResult> GetAvailableSlots()
        {
            var availableSlots = await _doctorTimeSlotService.GetAvailableTimeSlots();
            return Ok(availableSlots);
        }
    }
}
