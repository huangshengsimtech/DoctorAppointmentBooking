using DoctorAppointmentBooking.Entities;
using DoctorAppointmentBooking.Repositories;
using DoctorAppointmentBooking.Services.Exceptions;

namespace DoctorAppointmentBooking.Services
{
    public class DoctorTimeSlotService : IDoctorTimeSlotService
    {
        private readonly IDoctorTimeSlotRepository _doctorTimeSlotRepository;

        public DoctorTimeSlotService(IDoctorTimeSlotRepository doctorTimeSlotRepository)
        {
            _doctorTimeSlotRepository = doctorTimeSlotRepository;
        }

        public async Task Create(DoctorTimeSlot doctorTimeSlot)
        {
            if (string.IsNullOrEmpty(doctorTimeSlot.DoctorName))
            {
                throw new DoctorNameException();
            }

            if (doctorTimeSlot.Cost <= 0)
            {
                throw new DoctorTimeSlotCostException();
            }
            if (await _doctorTimeSlotRepository.DoesTimeSlotExist(doctorTimeSlot.Time))
            {
                throw new DoctorTimeSlotException();
            }

            await _doctorTimeSlotRepository.Add(doctorTimeSlot);
        }

        public async Task<List<DoctorTimeSlot>> GetTimeSlotsByDoctorId(Guid doctorId)
        {
            return await _doctorTimeSlotRepository.GetByDoctorIdAsync(doctorId);
        }

        public async Task<List<DoctorTimeSlot>> GetAvailableTimeSlots()
        {
            return await _doctorTimeSlotRepository.GetAvailableTimeSlotsAsync();
        }

        public async Task ReserveTimeSlot(Guid id)
        {
            await _doctorTimeSlotRepository.UpdateDoctorTimeSlotReservedStatus(id);
        }
    }
}
