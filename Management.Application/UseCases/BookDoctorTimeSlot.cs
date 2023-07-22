using Management.Domain.Contracts;

namespace Management.Application.UseCases
{
    public class BookDoctorTimeSlot
    {
        private readonly IDoctorTimeSlotRepository _doctorTimeSlotRepository;

        public BookDoctorTimeSlot(IDoctorTimeSlotRepository doctorTimeSlotRepository)
        {
            _doctorTimeSlotRepository = doctorTimeSlotRepository;
        }

        public async Task Execute(Guid id)
        {
            await _doctorTimeSlotRepository.UpdateDoctorTimeSlotReservedStatus(id);
        }
    }

}
