using Notification.Application.Dtos;
using Notification.Domain.Contracts;
using Notification.Domain.Entities;

namespace Notification.Application.UseCases
{
    public class CreateAppointmentConfirmation
    {
        private readonly IAppointmentConfirmationRepository _appointmentConfirmationRepository;

        public CreateAppointmentConfirmation(IAppointmentConfirmationRepository appointmentConfirmationRepository)
        {
            _appointmentConfirmationRepository = appointmentConfirmationRepository;
        }

        public async Task Execute(CreateAppointmentConfirmationRequest request)
        {
            var appointmentConfirmation = AppointmentConfirmation.CreateNew(
                request.SlotId, 
                request.DoctorId, 
                request.PatientId,
                request.DoctorName,
                request.PatientName, 
                request.Time);
            await _appointmentConfirmationRepository.Add(appointmentConfirmation);
        }
    }
}
