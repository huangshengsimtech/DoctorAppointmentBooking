using Notification.Domain.Entities;

namespace Notification.Domain.Contracts
{
    public interface IAppointmentConfirmationRepository
    {
        public Task Add(AppointmentConfirmation appointmentConfirmation);
        public Task<AppointmentConfirmation?> GetBySlotId(Guid slotId);
    }
}
