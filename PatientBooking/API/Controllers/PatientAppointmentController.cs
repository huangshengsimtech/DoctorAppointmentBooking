using Booking.Application.UseCases;
using Booking.Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Booking.API.Controllers
{
    [ApiController]
    [Route("/booking")]

    public class PatientAppointmentController : ControllerBase
    {
        private readonly CreatePatientAppointment _createPatientAppointment;
        private readonly BookDoctorTimeSlotById _bookDoctorTimeSlotById;
        private readonly ILogger<PatientAppointmentController> _logger;
        public PatientAppointmentController(CreatePatientAppointment createPatientAppointment, BookDoctorTimeSlotById bookDoctorTimeSlotById, ILogger<PatientAppointmentController> logger)
        {
            _createPatientAppointment = createPatientAppointment;
            _bookDoctorTimeSlotById = bookDoctorTimeSlotById;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Booking Module!");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post([FromBody] CreatePatientAppointmentRequest createPatientAppointmentRequest)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(value => value.Errors)
                    .Select(error => error.ErrorMessage)
                    .ToList();

                return BadRequest(errors);
            }

            _logger.LogInformation("Appointment with ${PatientName} requested", createPatientAppointmentRequest.PatientName);

            await _bookDoctorTimeSlotById.Execute(createPatientAppointmentRequest.SlotId);

            await _createPatientAppointment.Execute(createPatientAppointmentRequest);

            return Ok("Patient Appointment Created...");
        }
    }
}
