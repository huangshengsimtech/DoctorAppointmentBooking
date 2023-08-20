using Management.Application.Contracts;
using Management.Application.Dtos;
using Management.Domain.Contracts;

namespace Management.Application.UseCases
{
    public class BookDoctorTimeSlot
    {
        private readonly IDoctorTimeSlotRepository _doctorTimeSlotRepository;
        private readonly ISlotPublisher _slotPublisher;

        public BookDoctorTimeSlot(IDoctorTimeSlotRepository doctorTimeSlotRepository, ISlotPublisher slotPublisher)
        {
            _doctorTimeSlotRepository = doctorTimeSlotRepository;
            _slotPublisher = slotPublisher;
        }

        public async Task Execute(Guid id)
        {
            await _doctorTimeSlotRepository.UpdateDoctorTimeSlotReservedStatus(id);
            await _slotPublisher.Publish(new DoctorTimeSlotModified(id));
        }
    }
}
