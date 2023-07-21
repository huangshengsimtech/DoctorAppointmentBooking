using Booking.Domain.Entities;
using Booking.Domain.Contracts;
using Booking.Domain.Exceptions;
using Booking.Application.Dtos;

namespace Booking.Application.UseCases
{
    public class CreatePatientAppointment
    {
        private readonly IPatientAppointmentRepository _patientAppointmentRepository;

        public CreatePatientAppointment(IPatientAppointmentRepository patientAppointmentRepository)
        {
            _patientAppointmentRepository = patientAppointmentRepository;
        }

        public async Task Execute(CreatePatientAppointmentRequest createPatientAppointmentRequest)
        {
            if (string.IsNullOrEmpty(createPatientAppointmentRequest.PatientName))
            {
                throw new PatientNameEmptyException();
            }

            // Convert to PatientAppointment domain model
            var patientAppointment = PatientAppointment.CreateNew(
                createPatientAppointmentRequest.Id, 
                createPatientAppointmentRequest.SlotId, 
                createPatientAppointmentRequest.PatientId,
                createPatientAppointmentRequest.PatientName, 
                createPatientAppointmentRequest.ReservedAt);

            await _patientAppointmentRepository.Add(patientAppointment);
        }
    }

}
