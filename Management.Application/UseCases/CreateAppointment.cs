using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management.Application.Dtos;
using Management.Domain.Contracts;
using Management.Domain.Entities;
using Management.Domain.Exceptions;


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
            //if (request.SellingPrice == 0 || request.CostPrice == 0 || request.SellingPrice < request.CostPrice)
            //    throw new PriceException();

            // Convert to Appointment domain model
            var appointment = Appointment.CreateNew(request.Id, request.SlotId, request.PatientId,
                request.PatientName, request.ReservedAt);
            await _appointmentRepository.Add(appointment);
        }
    }
}
