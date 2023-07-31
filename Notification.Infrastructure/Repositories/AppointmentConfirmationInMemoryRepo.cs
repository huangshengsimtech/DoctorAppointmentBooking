using Notification.Domain.Contracts;
using Notification.Domain.Entities;
using Microsoft.Extensions.Logging;
using Serilog;


namespace Notification.Infrastructure.Repositories
{
    public class AppointmentConfirmationInMemoryRepo : IAppointmentConfirmationRepository
    {
        private static readonly List<AppointmentConfirmation> AppointmentConfirmations = new();

        private readonly ILogger<AppointmentConfirmationInMemoryRepo> _logger;
        public AppointmentConfirmationInMemoryRepo(ILogger<AppointmentConfirmationInMemoryRepo> logger)
        {
            _logger = logger;
        }

        public async Task Add(AppointmentConfirmation appointmentConfirmation)
        {
            AppointmentConfirmations.Add(appointmentConfirmation);
            Log.Information("Hello, the appointment has been confirmed!");
            Log.Information("Appointment created for Patient: {PatientName} with Doctor: {DoctorName} at Time: {Time}",
                appointmentConfirmation.PatientName, appointmentConfirmation.DoctorName, appointmentConfirmation.Time);

            _logger.LogInformation("(ILogger<AppointmentConfirmationInMemoryRepo> logger) Hello, the appointment has been confirmed!");
            _logger.LogInformation("(ILogger) Appointment created for Patient: {PatientName} with Doctor: {DoctorName} at Time: {Time}",
                appointmentConfirmation.PatientName, appointmentConfirmation.DoctorName, appointmentConfirmation.Time);
        }

        public Task<AppointmentConfirmation?> GetBySlotId(Guid slotId)
        {
            return Task.FromResult(AppointmentConfirmations.SingleOrDefault(x => x.SlotId == slotId));
        }
    }
}
