using DoctorAppointmentBooking.Entities;

namespace DoctorAppointmentBooking.Repositories
{
    public class DoctorTimeSlotRepository : IDoctorTimeSlotRepository
    {
        public Task Add(DoctorTimeSlot doctorTimeSlot)
        {
            throw new NotImplementedException();
        }
        //private readonly DoctorAppointmentBookingContext _context;

        //public DoctorTimeSlotRepository(DoctorAppointmentBookingContext context)
        //{
        //    _context = context;
        //}

        //public async Task<DoctorTimeSlot> GetDoctorTimeSlotByIdAsync(int id)
        //{
        //    return await _context.DoctorTimeSlots.FindAsync(id);
        //}

        //public async Task<IEnumerable<DoctorTimeSlot>> GetDoctorTimeSlotsAsync()
        //{
        //    return await _context.DoctorTimeSlots.ToListAsync();
        //}

        //public async Task<IEnumerable<DoctorTimeSlot>> GetDoctorTimeSlotsByDoctorIdAsync(int doctorId)
        //{
        //    return await _context.DoctorTimeSlots.Where(d => d.DoctorId == doctorId).ToListAsync();
        //}

        //public async Task<IEnumerable<DoctorTimeSlot>> GetDoctorTimeSlotsByDoctorIdAndDateAsync(int doctorId, DateTime date)
        //{
        //    return await _context.DoctorTimeSlots.Where(d => d.DoctorId == doctorId && d.Date == date).ToListAsync();
        //}

        //public async Task<IEnumerable<DoctorTimeSlot>> GetDoctorTimeSlotsByDoctorIdAndDateAndTimeAsync(int doctorId, DateTime date, TimeSpan time)
        //{
        //    return await _context.DoctorTimeSlots.Where(d => d.DoctorId == doctorId && d.Date == date && d.Time == time).ToListAsync();
        //}

        //public async Task<IEnumerable<DoctorTimeSlot>> GetDoctorTimeSlotsByDoctorIdAndDateAndTimeAndIsAvailableAsync(int doctorId, DateTime date, TimeSpan time, bool isAvailable)
        //{
        //    return await _context.DoctorTimeSlots.Where(d => d.DoctorId == doctorId && d.Date == date && d.Time == time && d.IsAvailable == isAvailable).ToListAsync();
        //}

        //public async Task<IEnumerable<DoctorTimeSlot>> GetDoctorTimeSlotsByDoctorIdAndDateAndIsAvailableAsync(int doctorId, DateTime date, bool isAvailable)
        //{
        //    return await _context.DoctorTimeSlots.Where(d => d.DoctorId == doctorId && d.Date == date && d.IsAvailable == isAvailable).ToListAsync();
        //}

        //public async Task<IEnumerable<DoctorTimeSlot>> GetDoctorTimeSlotsByDoctorIdAndIsAvailableAsync(int doctorId, bool isAvailable)
        //{
        //    return await _context.DoctorTimeSlots.Where(d => d.DoctorId == doctorId && d.IsAvailable == isAvailable).ToListAsync();
        //}

        //public async Task<IEnumerable<DoctorTimeSlot>>
    }
}
