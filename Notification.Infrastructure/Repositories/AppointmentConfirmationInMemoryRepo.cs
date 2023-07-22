using Notification.Domain.Contracts;
using Notification.Domain.Entities;
using Serilog;


namespace Notification.Infrastructure.Repositories
{
    public class AppointmentConfirmationInMemoryRepo : IAppointmentConfirmationRepository
    {
        private static readonly List<AppointmentConfirmation> AppointmentConfirmations = new();

        public async Task Add(AppointmentConfirmation appointmentConfirmation)
        {
            AppointmentConfirmations.Add(appointmentConfirmation);
            Log.Information("Hello, the appointment has been confirmed!");
            Log.Information("Appointment created for Patient: {PatientName} with Doctor: {DoctorName} at Time: {Time}",
        appointmentConfirmation.PatientName, appointmentConfirmation.DoctorName, appointmentConfirmation.Time);
        }

        public Task<AppointmentConfirmation?> GetBySlotId(Guid slotId)
        {
            return Task.FromResult(AppointmentConfirmations.SingleOrDefault(x => x.SlotId == slotId));
        }
    }
}
