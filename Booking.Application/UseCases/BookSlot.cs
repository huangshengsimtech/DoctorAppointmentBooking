using Management.Shared;
using Booking.Application.UseCases.Dtos;

namespace Booking.Application.UseCases
{
    public class BookSlot
    {
        private readonly IManagementModuleAPI _managementModuleAPI;

        public BookSlot(IManagementModuleAPI managementModuleAPI)
        {
            _managementModuleAPI = managementModuleAPI;
        }

        public Task Execute(BookSlotRequest request)
        {
            var timeSlot = _managementModuleAPI.GetTimeSlotById(request.SlotId);
            if (timeSlot == null)
                throw new TimeSlotNotFoundException();

            Console.Write("Selected Time Slot.");
            return Task.CompletedTask;
        }
    }

    public class TimeSlotNotFoundException : Exception
    {
    }
}
