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
                throw new DoctorTimeSlotException();
            }

            if (doctorTimeSlot.Cost == 0)
                throw new NotImplementedException();

            await _doctorTimeSlotRepository.Add(doctorTimeSlot);
        }
        public async Task<List<DoctorTimeSlot>> GetAvailableTimeSlots()
        {
            return await _doctorTimeSlotRepository.GetAvailableTimeSlotsAsync();
        }

    }
}
