using Booking.API.Controllers;
using Booking.Domain.Contracts;
using Booking.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace Booking.Infrastructure.Repositories
{
    public class PatientAppointmentInMemoryRepo : IPatientAppointmentRepository
    {
        private static readonly List<PatientAppointment> PatientAppointments = new();

        private readonly ILogger<PatientAppointmentController> _logger;
        public PatientAppointmentInMemoryRepo(ILogger<PatientAppointmentController> logger)
        {
            _logger = logger;
        }
        public async Task Add(PatientAppointment patientAppointment)
        {
            _logger.LogInformation("Appointment with ${PatientName} has added into database.", patientAppointment.PatientName);

            PatientAppointments.Add(patientAppointment);
        }

        public Task<PatientAppointment?> GetById(Guid id)
        {
            return Task.FromResult(PatientAppointments.SingleOrDefault(x => x.Id == id));
        }
    }

}
