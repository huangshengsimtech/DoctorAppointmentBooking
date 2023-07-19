using Management.Domain.Contracts;
using Management.Domain.Entities;

namespace Management.Application.UseCases
{
    public class GetDoctorAvailableTimeSlots
    {
        private readonly IDoctorTimeSlotRepository _doctorTimeSlotRepository;

        public GetDoctorAvailableTimeSlots(IDoctorTimeSlotRepository doctorTimeSlotRepository)
        {
            _doctorTimeSlotRepository = doctorTimeSlotRepository;
        }

        public async Task<List<DoctorTimeSlot>> Execute()
        {
            return await _doctorTimeSlotRepository.GetAvailableTimeSlotsAsync();
        }
    }

}
