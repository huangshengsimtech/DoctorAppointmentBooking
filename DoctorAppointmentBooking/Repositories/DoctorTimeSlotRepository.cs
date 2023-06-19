using DoctorAppointmentBooking.Database;
using DoctorAppointmentBooking.Entities;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointmentBooking.Repositories
{
    public class DoctorTimeSlotRepository : IDoctorTimeSlotRepository
    {
        private readonly BookingDatabase _db;

        public DoctorTimeSlotRepository(BookingDatabase db)
        {
            _db = db;
        }

        public async Task Add(DoctorTimeSlot doctorTimeSlot)
        {
            _db.DoctorTimeSlots.Add(doctorTimeSlot);
            await _db.SaveChangesAsync();
        }
        public async Task<List<DoctorTimeSlot>> GetByDoctorIdAsync(Guid doctorId)
        {
            return await _db.DoctorTimeSlots.Where(d => d.DoctorId == doctorId).ToListAsync();
        }
        public async Task<List<DoctorTimeSlot>> GetAvailableTimeSlotsAsync()
        {
            return await _db.DoctorTimeSlots.Where(d => !d.IsReserved).ToListAsync();
        }
    }
}
