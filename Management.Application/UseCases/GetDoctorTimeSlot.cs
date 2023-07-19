using Management.Domain.Contracts;
using Management.Domain.Entities;

namespace Management.Application.UseCases
{
    public class GetDoctorTimeSlot
    {
        private readonly IDoctorTimeSlotRepository _doctorTimeSlotRepository;

        public GetDoctorTimeSlot(IDoctorTimeSlotRepository doctorTimeSlotRepository)
        {
            _doctorTimeSlotRepository = doctorTimeSlotRepository;
        }

        public async Task<List<DoctorTimeSlot>> Execute(Guid doctorId)
        {
            return await _doctorTimeSlotRepository.GetByDoctorIdAsync(doctorId);
        }
    }
}
