using Booking.Application.UseCases;
using Booking.Application.UseCases.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers
{
    [ApiController]
    [Route("/booking")]

    public class BookingController : ControllerBase
    {
        private BookSlot _bookSlot;

        public BookingController(BookSlot bookSlot)
        {
            _bookSlot = bookSlot;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Booking Module");
        }

        [HttpPost]
        public async Task<IActionResult> Book(BookSlotRequest request)
        {
            await _bookSlot.Execute(request);
            return Ok("Time Slot Booked!");
        }
    }
}
