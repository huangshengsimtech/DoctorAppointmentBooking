using DoctorAppointmentBookingLayered.Entities;

namespace DoctorAppointmentBookingLayered.Services
{
    public interface IAppointmentService
    {
        public Task Create(Appointment appointment);
    }
}
