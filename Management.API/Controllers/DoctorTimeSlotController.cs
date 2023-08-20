using Management.Application.Dtos;
using Management.Application.UseCases;
using Management.Domain.Entities;
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
        private readonly BookDoctorTimeSlot _bookDoctorTimeSlot;
        private readonly GetDoctorTimeSlot _getDoctorTimeSlot;
        private readonly GetDoctorAvailableTimeSlots _getDoctorAvailableTimeSlots;
        private readonly ILogger<DoctorTimeSlotController> _logger;

        public DoctorTimeSlotController(CreateDoctorTimeSlot createDoctorTimeSlot,
                                        BookDoctorTimeSlot bookDoctorTimeSlot,
                                        GetDoctorTimeSlot getDoctorTimeSlot,
                                        GetDoctorAvailableTimeSlots getDoctorAvailableTimeSlots,
                                        ILogger<DoctorTimeSlotController> logger)
        {
            _createDoctorTimeSlot = createDoctorTimeSlot;
            _bookDoctorTimeSlot = bookDoctorTimeSlot;
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
            _logger.LogInformation("Get timeslots by doctor ID: ${doctorId}", doctorId);
            var slots = await _getDoctorTimeSlot.Execute(doctorId);
            return Ok(slots);
        }
        [HttpGet("get-doctor-available-time-slots")]
        public async Task<IActionResult> GetAvailableSlots()
        {
            var availableSlots = await _getDoctorAvailableTimeSlots.Execute();
            return Ok(availableSlots);
        }

        [HttpPut("{id}/reserve")]
        public async Task<IActionResult> Reserve(Guid id)
        {
            await _bookDoctorTimeSlot.Execute(id);
            return Ok("Doctor Time Slot Reserved..");
        }
    }
}
