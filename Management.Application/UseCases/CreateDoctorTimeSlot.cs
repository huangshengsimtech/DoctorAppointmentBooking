using Management.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management.Domain.Contracts;
using Management.Domain.Entities;
using Management.Domain.Exceptions;

namespace Management.Application.UseCases
{
    public class CreateDoctorTimeSlot
    {
        private readonly IDoctorTimeSlotRepository _doctorTimeSlotRepository;

        public CreateDoctorTimeSlot(IDoctorTimeSlotRepository doctorTimeSlotRepository)
        {
            _doctorTimeSlotRepository = doctorTimeSlotRepository;
        }

        public async Task Execute(CreateDoctorTimeSlotRequest request)
        {
            //if (request.SellingPrice == 0 || request.CostPrice == 0 || request.SellingPrice < request.CostPrice)
            //    throw new PriceException();

            // Convert to Appointment domain model
            var doctorTimeSlot = DoctorTimeSlot.CreateNew(request.Id, request.Time, request.DoctorId,
                request.DoctorName, request.IsReserved, request.Cost);
            await _doctorTimeSlotRepository.Add(doctorTimeSlot);
        }
    }

}
