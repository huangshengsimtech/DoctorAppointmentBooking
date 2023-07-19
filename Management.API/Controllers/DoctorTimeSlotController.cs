using Microsoft.AspNetCore.Mvc;
using Management.Application.Dtos;
using Management.Application.UseCases;
using Microsoft.Extensions.Logging;

namespace Management.API.Controllers
{
    [Controller]
    [Route("/doctortimeslots")]
    public class DoctorTimeSlotController : ControllerBase
    {
        private readonly CreateDoctorTimeSlot _createDoctorTimeSlot;
        private readonly ILogger<DoctorTimeSlotController> _logger;

        public DoctorTimeSlotController(CreateDoctorTimeSlot createDoctorTimeSlot, ILogger<DoctorTimeSlotController> logger)
        {
            _createDoctorTimeSlot = createDoctorTimeSlot;
            _logger = logger;
        }

        [HttpPost("create")]

        public async Task<IActionResult> Post([FromBody] CreateDoctorTimeSlotRequest doctorTimeSlot)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(value => value.Errors)
                    .Select(error => error.ErrorMessage)
                    .ToList();

                return BadRequest(errors);
            }

            _logger.LogInformation("DoctorTimeSlot with ${DoctorName} requested", doctorTimeSlot.DoctorName);
            await _createDoctorTimeSlot.Execute(doctorTimeSlot);

            return Ok("DoctorTimeSlot Created..");
        }

        //[HttpGet("{doctorId}")]
        //public async Task<IActionResult> GetTimeSlotsByDoctorId(Guid doctorId)
        //{
        //    var slots = await _doctorTimeSlotService.GetTimeSlotsByDoctorId(doctorId);
        //    return Ok(slots);
        //}
        //[HttpGet("available")]
        //public async Task<IActionResult> GetAvailableSlots()
        //{
        //    var availableSlots = await _doctorTimeSlotService.GetAvailableTimeSlots();
        //    return Ok(availableSlots);
        //}

        //[HttpPut("{id}/reserve")]
        //public async Task<IActionResult> Reserve(Guid id)
        //{
        //    await _doctorTimeSlotService.ReserveTimeSlot(id);
        //    return Ok("Doctor Time Slot Reserved..");
        //}

    }
}
