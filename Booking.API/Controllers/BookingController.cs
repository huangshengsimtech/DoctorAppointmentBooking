using Booking.Application.UseCases;
using Booking.Application.UseCases.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers
{
    [ApiController]
    [Route("/BookingInquiry")]

    public class BookingController : ControllerBase
    {
        private BookSlot _bookSlot;

        public BookingController(BookSlot bookSlot)
        {
            _bookSlot = bookSlot;
        }
        [HttpGet]
        public async Task<IActionResult> GetTimeSlotById(BookSlotRequest request)
        {
            return Ok(await _bookSlot.Execute(request));
        }
    }
}
