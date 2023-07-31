using DoctorAppointmentBookingLayered.Entities;
using DoctorAppointmentBookingLayered.Repositories;
using DoctorAppointmentBookingLayered.Services.Exceptions;

namespace DoctorAppointmentBookingLayered.Services
{
    public class DoctorTimeSlotServiceLayered : IDoctorTimeSlotServiceLayered
    {
        private readonly IDoctorTimeSlotInMemoryRepoLayered _doctorTimeSlotRepository;

        public DoctorTimeSlotServiceLayered(IDoctorTimeSlotInMemoryRepoLayered doctorTimeSlotRepository)
        {
            _doctorTimeSlotRepository = doctorTimeSlotRepository;
        }

        public async Task Create(DoctorTimeSlotLayered doctorTimeSlot)
        {
            if (string.IsNullOrEmpty(doctorTimeSlot.DoctorName))
            {
                throw new DoctorNameExceptionLayered();
            }

            if (doctorTimeSlot.Cost <= 0)
            {
                throw new DoctorTimeSlotCostExceptionLayered();
            }
            if (await _doctorTimeSlotRepository.DoesTimeSlotExist(doctorTimeSlot.Time))
            {
                throw new DoctorTimeSlotExceptionLayered();
            }

            await _doctorTimeSlotRepository.Add(doctorTimeSlot);
        }

        public async Task<List<DoctorTimeSlotLayered>> GetTimeSlotsByDoctorId(Guid doctorId)
        {
            return await _doctorTimeSlotRepository.GetByDoctorIdAsync(doctorId);
        }
        public async Task<DoctorTimeSlotLayered?> GetTimeSlotById(Guid Id)
        {
            return await _doctorTimeSlotRepository.GetById(Id);
        }

        public async Task<List<DoctorTimeSlotLayered>> GetAvailableTimeSlots()
        {
            return await _doctorTimeSlotRepository.GetAvailableTimeSlotsAsync();
        }

        public async Task ReserveTimeSlot(Guid id)
        {
            await _doctorTimeSlotRepository.UpdateDoctorTimeSlotReservedStatus(id);
        }
    }
}
