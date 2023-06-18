using DoctorAppointmentBooking.Entities;
using DoctorAppointmentBooking.Repositories;

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
            if (doctorTimeSlot.Cost == 0 || doctorTimeSlot.IsReserved == true || doctorTimeSlot.DoctorName == null)
                throw new NotImplementedException();

            await _doctorTimeSlotRepository.Add(doctorTimeSlot);
        }
    }
}
