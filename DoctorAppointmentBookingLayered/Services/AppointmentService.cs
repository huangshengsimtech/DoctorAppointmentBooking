using DoctorAppointmentBookingLayered.Entities;
using DoctorAppointmentBookingLayered.Repositories;
using DoctorAppointmentBookingLayered.Services.Exceptions;

namespace DoctorAppointmentBookingLayered.Services
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
