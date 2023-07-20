using Management.Domain.Contracts;
using Management.Domain.Entities;

namespace Management.Application.UseCases
{
    public class GetDoctorTimeSlotById
    {
        private readonly IDoctorTimeSlotRepository _doctorTimeSlotRepository;

        public GetDoctorTimeSlotById(IDoctorTimeSlotRepository doctorTimeSlotRepository)
        {
            _doctorTimeSlotRepository = doctorTimeSlotRepository;
        }

        public async Task<DoctorTimeSlot?> Execute(Guid id)
        {
            return await _doctorTimeSlotRepository.GetById(id);
        }
    }
}
