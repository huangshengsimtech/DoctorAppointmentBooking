using Notification.Application.UseCases;
using Notification.Domain.Entities;
using Notification.Shared;

namespace Notification.API.Services
{
    public class NotificationModuleAPI : INotificationModuleAPI
    {
        private readonly CreateAppointmentConfirmationShared _createAppointmentConfirmationShared;

        public NotificationModuleAPI(CreateAppointmentConfirmationShared createAppointmentConfirmationShared)
        {
            _createAppointmentConfirmationShared = createAppointmentConfirmationShared;
        }

        public async Task CreateNotification(AppointmentConfirmationDto appointmentConfirmationDto)
        {
            var appointmentConfirmation = AppointmentConfirmation.CreateNew(
                appointmentConfirmationDto.SlotId,
                appointmentConfirmationDto.DoctorId,
                appointmentConfirmationDto.PatientId,
                appointmentConfirmationDto.DoctorName,
                appointmentConfirmationDto.PatientName,
                appointmentConfirmationDto.Time
            );

            await _createAppointmentConfirmationShared.Execute(appointmentConfirmation);
        }
    }
}
