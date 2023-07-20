using Microsoft.AspNetCore.Mvc;
using Management.Application.Dtos;
using Management.Application.UseCases;
using Microsoft.Extensions.Logging;

namespace Management.API.Controllers
{
    [ApiController]
    [Route("/appointments")]
    public class AppointmentController : ControllerBase
    {
        private readonly CreateAppointment _createAppointment;
        private readonly ILogger<AppointmentController> _logger;

        public AppointmentController(CreateAppointment createAppointment, ILogger<AppointmentController> logger)
        {
            _createAppointment = createAppointment;
            _logger = logger;
        }
        public IActionResult Get()
        {
            return Ok("Appointment in Management Module");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateAppointmentRequest appointment)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(value => value.Errors)
                    .Select(error => error.ErrorMessage)
                    .ToList();

                return BadRequest(errors);
            }

            _logger.LogInformation("Appointment with ${PatientName} requested", appointment.PatientName);
            await _createAppointment.Execute(appointment);

            return Ok("Appointment Created..");
        }
    }
}
