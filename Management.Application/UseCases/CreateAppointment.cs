using Management.Application.Dtos;
using Management.Domain.Contracts;
using Management.Domain.Entities;


namespace Management.Application.UseCases
{
    public class CreateAppointment
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public CreateAppointment(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task Execute(CreateAppointmentRequest request)
        {
            // Convert to Appointment domain model
            var appointment = Appointment.CreateNew(request.Id, request.SlotId, request.PatientId,
                request.PatientName, request.ReservedAt);
            await _appointmentRepository.Add(appointment);
        }
    }
}
