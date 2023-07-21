using Booking.Domain.Entities;

namespace Booking.Domain.Contracts
{
    public interface IPatientAppointmentRepository
    {
        public Task Add(PatientAppointment patientAppointment);
    }

}
