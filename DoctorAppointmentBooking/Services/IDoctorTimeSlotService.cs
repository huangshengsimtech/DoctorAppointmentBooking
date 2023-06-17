using DoctorAppointmentBooking.Entities;

namespace DoctorAppointmentBooking.Services
{
    public interface IDoctorTimeSlotService
    {
        public Task Create(DoctorTimeSlot doctorTimeSlot);
    }
}
