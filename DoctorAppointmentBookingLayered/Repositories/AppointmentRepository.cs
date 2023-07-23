using DoctorAppointmentBookingLayered.Database;
using DoctorAppointmentBookingLayered.Entities;

namespace DoctorAppointmentBookingLayered.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly BookingDatabase _db;

        public AppointmentRepository(BookingDatabase db)
        {
            _db = db;
        }

        public async Task Add(Appointment appointment)
        {
            _db.Appointments.Add(appointment);
            await _db.SaveChangesAsync();
        }
    }
}
