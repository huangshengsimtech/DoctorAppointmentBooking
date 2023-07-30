using DoctorAppointmentBookingLayered.Entities;
using DoctorAppointmentBookingLayered.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointmentBookingLayered.Controllers
{
    [Controller]
    [Route("/doctortimeslots")]
    public class DoctorTimeSlotControllerLayered : ControllerBase
    {
        private readonly IDoctorTimeSlotServiceLayered _doctorTimeSlotService;

        public DoctorTimeSlotControllerLayered(IDoctorTimeSlotServiceLayered doctorTimeSlotService)
        {
            _doctorTimeSlotService = doctorTimeSlotService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("DoctorAppointmentBookingLayered Module!");
        }

        [HttpPost("create")]
        public async Task<IActionResult> Post([FromBody] DoctorTimeSlotLayered doctorTimeSlot)
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
        [HttpGet("{doctorId}")]
        public async Task<IActionResult> GetTimeSlotsByDoctorId(Guid doctorId)
        {
            var slots = await _doctorTimeSlotService.GetTimeSlotsByDoctorId(doctorId);
            return Ok(slots);
        }
        [HttpGet("available")]
        public async Task<IActionResult> GetAvailableSlots()
        {
            var availableSlots = await _doctorTimeSlotService.GetAvailableTimeSlots();
            return Ok(availableSlots);
        }

        [HttpPut("{id}/reserve")]
        public async Task<IActionResult> Reserve(Guid id)
        {
            await _doctorTimeSlotService.ReserveTimeSlot(id);
            return Ok("Doctor Time Slot Reserved..");
        }

    }
}
