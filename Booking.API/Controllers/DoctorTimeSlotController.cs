using BookingInquiry.Application.UseCases;
using BookingInquiry.Application.UseCases.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace BookingInquiry.API.Controllers
{
    [ApiController]
    [Route("/booking-inquiry")]

    public class DoctorTimeSlotController : ControllerBase
    {
        private CheckDoctorTimeSlot _checkDoctorTimeSlot;

        public DoctorTimeSlotController(CheckDoctorTimeSlot checkDoctorTimeSlot)
        {
            _checkDoctorTimeSlot = checkDoctorTimeSlot;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("BookingInquiry Module!");
        }
        [HttpGet("get-doctor-time-slot-by-id")]
        [Authorize]
        public async Task<IActionResult> GetTimeSlotById(DoctorTimeSlotRequest request)
        {
            return Ok(await _checkDoctorTimeSlot.Execute(request));
        }
    }
}
