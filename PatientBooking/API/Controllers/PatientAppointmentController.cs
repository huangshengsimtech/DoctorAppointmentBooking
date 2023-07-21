using PatientBooking.Application.UseCases;
using PatientBooking.Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PatientBooking.API.Controllers
{
    [ApiController]
    [Route("/Booking")]

    public class PatientAppointmentController : ControllerBase
    {
        private readonly CreatePatientAppointment _createPatientAppointment;
        private readonly ILogger<PatientAppointmentController> _logger;

        public PatientAppointmentController(CreatePatientAppointment createPatientAppointment, ILogger<PatientAppointmentController> logger)
        {
            _createPatientAppointment = createPatientAppointment;
            _logger = logger;
        }
        public IActionResult Get()
        {
            return Ok("Booking Module!");
        }

        [HttpPost]
        //[Authorize]
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
            await _createPatientAppointment.Execute(createPatientAppointmentRequest);

            return Ok("Patient Appointment Created...");
        }
    }

}
