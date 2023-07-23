using DoctorAppointmentBookingLayered.Database;
using DoctorAppointmentBookingLayered.Entities;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointmentBookingLayered.Repositories
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
        public async Task<bool> DoesTimeSlotExist(DateTime time)
        {
            return await _db.DoctorTimeSlots.AnyAsync(d => d.Time == time);
        }
        public async Task UpdateDoctorTimeSlotReservedStatus(Guid id)
        {
            var doctorTimeSlot = await _db.DoctorTimeSlots.FindAsync(id);
            if (doctorTimeSlot != null)
            {
                doctorTimeSlot.IsReserved = true;
                await _db.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Doctor time slot not found!");
            }
        }
    }
}
