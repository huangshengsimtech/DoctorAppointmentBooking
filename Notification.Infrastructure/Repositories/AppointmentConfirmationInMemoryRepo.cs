using Notification.Domain.Contracts;
using Notification.Domain.Entities;

namespace Notification.Infrastructure.Repositories
{
    public class AppointmentConfirmationInMemoryRepo : IAppointmentConfirmationRepository
    {
        private static readonly List<AppointmentConfirmation> AppointmentConfirmations = new();

        public async Task Add(AppointmentConfirmation appointmentConfirmation)
        {
            AppointmentConfirmations.Add(appointmentConfirmation);
        }

        public Task<AppointmentConfirmation?> GetBySlotId(Guid slotId)
        {
            return Task.FromResult(AppointmentConfirmations.SingleOrDefault(x => x.SlotId == slotId));
        }
    }
}
