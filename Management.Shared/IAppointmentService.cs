using DoctorAppointmentBooking.Entities;

namespace DoctorAppointmentBooking.Services
{
    public interface IAppointmentService
    {
        public Task Create(Appointment appointment);
    }
}
