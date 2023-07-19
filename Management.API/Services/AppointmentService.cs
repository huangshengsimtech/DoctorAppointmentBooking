using Management.Domain.Entities;
using Management.Infrastructure.Repositories;
using Management.Domain.Exceptions;
using Management.Shared;
using Management.Domain.Contracts;


namespace Management.API.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task Create(Appointment appointment)
        {
            if (string.IsNullOrEmpty(appointment.PatientName))
            {
                throw new AppointmentException();
            }

            await _appointmentRepository.Add(appointment);
        }
    }
}
