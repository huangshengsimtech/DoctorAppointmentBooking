using PatientBooking.Domain.Contracts;
using PatientBooking.Domain.Entities;

namespace PatientBooking.Infrastructure.Repositories
{
    public class PatientAppointmentInMemoryRepo : IPatientAppointmentRepository
    {
        private static readonly List<PatientAppointment> PatientAppointments = new();

        public async Task Add(PatientAppointment patientAppointment)
        {
            PatientAppointments.Add(patientAppointment);
        }

        public Task<PatientAppointment?> GetById(Guid id)
        {
            return Task.FromResult(PatientAppointments.SingleOrDefault(x => x.Id == id));
        }
    }

}
