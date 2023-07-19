using Management.Application.Dtos;
using Management.Domain.Contracts;
using Management.Domain.Entities;

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
            // Convert to DoctorTimeSlot domain model
            var doctorTimeSlot = DoctorTimeSlot.CreateNew(request.Id, request.Time, request.DoctorId,
                request.DoctorName, request.IsReserved, request.Cost);
            await _doctorTimeSlotRepository.Add(doctorTimeSlot);
        }
    }

}
