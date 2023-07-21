using PatientBooking.Domain.Entities;

namespace PatientBooking.Domain.Contracts
{
    public interface IPatientAppointmentRepository
    {
        public Task Add(PatientAppointment patientAppointment);
    }

}
