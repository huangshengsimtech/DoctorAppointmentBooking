using BookingInquiry.Application.UseCases;
using BookingInquiry.Application.UseCases.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BookingInquiry.API.Controllers
{
    [ApiController]
    [Route("/BookingInquiry")]

    public class BookingController : ControllerBase
    {
        private CheckDoctorTimeSlot _checkDoctorTimeSlot;

        public BookingController(CheckDoctorTimeSlot checkDoctorTimeSlot)
        {
            _checkDoctorTimeSlot = checkDoctorTimeSlot;
        }
        [HttpGet]
        public async Task<IActionResult> GetTimeSlotById(DoctorTimeSlotRequest request)
        {
            return Ok(await _checkDoctorTimeSlot.Execute(request));
        }
    }
}
