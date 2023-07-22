using Management.Application.Dtos;
using Management.Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Management.API.Controllers
{
    [ApiController]
    [Route("/management")]
    public class DoctorTimeSlotController : ControllerBase
    {
        private readonly CreateDoctorTimeSlot _createDoctorTimeSlot;
        private readonly GetDoctorTimeSlot _getDoctorTimeSlot;
        private readonly GetDoctorAvailableTimeSlots _getDoctorAvailableTimeSlots;
        private readonly ILogger<DoctorTimeSlotController> _logger;

        public DoctorTimeSlotController(CreateDoctorTimeSlot createDoctorTimeSlot,
                                        GetDoctorTimeSlot getDoctorTimeSlot,
                                        GetDoctorAvailableTimeSlots getDoctorAvailableTimeSlots,
                                        ILogger<DoctorTimeSlotController> logger)
        {
            _createDoctorTimeSlot = createDoctorTimeSlot;
            _getDoctorTimeSlot = getDoctorTimeSlot;
            _getDoctorAvailableTimeSlots = getDoctorAvailableTimeSlots;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Management Module!");
        }

        [HttpPost("create-doctor-time-slot")]
        [Authorize]
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

        [HttpGet("get-time-slots-by-doctor-id/{doctorId}")]
        public async Task<IActionResult> GetTimeSlotsByDoctorId(Guid doctorId)
        {
            var slots = await _getDoctorTimeSlot.Execute(doctorId);
            return Ok(slots);
        }
        [HttpGet("get-doctor-available-time-slots")]
        public async Task<IActionResult> GetAvailableSlots()
        {
            var availableSlots = await _getDoctorAvailableTimeSlots.Execute();
            return Ok(availableSlots);
        }
    }
}
