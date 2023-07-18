using Microsoft.AspNetCore.Mvc;
using Management.Application.Dtos;
using Management.Application.UseCases;
namespace DoctorAppointmentBooking.Controllers
{
    [Route("/appointments")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

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

            await _appointmentService.Create(appointment);
            return Ok("Appointment Created..");
        }
    }
}
