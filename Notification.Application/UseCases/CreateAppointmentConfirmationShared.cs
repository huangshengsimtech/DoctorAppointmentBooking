using Notification.Domain.Entities;
using Notification.Domain.Contracts;

namespace Notification.Application.UseCases
{
    public class CreateAppointmentConfirmationShared
    {
        private readonly IAppointmentConfirmationRepository _appointmentConfirmationRepository;

        public CreateAppointmentConfirmationShared(IAppointmentConfirmationRepository appointmentConfirmationRepository)
        {
            _appointmentConfirmationRepository = appointmentConfirmationRepository;
        }

        public async Task Execute(AppointmentConfirmation appointmentConfirmation)
        {
            await _appointmentConfirmationRepository.Add(appointmentConfirmation);
        }
    }

}
