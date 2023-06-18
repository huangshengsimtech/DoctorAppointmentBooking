using DoctorAppointmentBooking.Entities;
using DoctorAppointmentBooking.Repositories;

namespace DoctorAppointmentBooking.Services
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
            if (appointment.PatientName == null)
                throw new NotImplementedException();
            
            await _appointmentRepository.Add(appointment);
        }
    }
}
