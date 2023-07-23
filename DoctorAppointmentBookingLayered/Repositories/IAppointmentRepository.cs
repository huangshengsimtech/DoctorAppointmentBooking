using DoctorAppointmentBookingLayered.Entities;

namespace DoctorAppointmentBookingLayered.Repositories
{
    public interface IAppointmentRepository
    {
        public Task Add(Appointment appointment);
    }
}
