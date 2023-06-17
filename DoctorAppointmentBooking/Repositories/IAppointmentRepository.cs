using DoctorAppointmentBooking.Entities;

namespace DoctorAppointmentBooking.Repositories
{
    public interface IAppointmentRepository
    {
        public Task Add(Appointment appointment);
    }
}
