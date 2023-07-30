using DoctorAppointmentBookingLayered.Entities;

namespace DoctorAppointmentBookingLayered.Repositories
{
    public class DoctorTimeSlotInMemoryRepoLayered : IDoctorTimeSlotInMemoryRepoLayered
    {
        private static readonly List<DoctorTimeSlotLayered> DoctorTimeSlots = new();

        public async Task Add(DoctorTimeSlotLayered doctorTimeSlot)
        {
            DoctorTimeSlots.Add(doctorTimeSlot);
        }

        public Task<DoctorTimeSlotLayered?> GetById(Guid id)
        {
            return Task.FromResult(DoctorTimeSlots.SingleOrDefault(x => x.Id == id));
        }
        public Task<List<DoctorTimeSlotLayered>> GetByDoctorIdAsync(Guid doctorId)
        {
            return Task.FromResult(DoctorTimeSlots.Where(d => d.DoctorId == doctorId).ToList());
        }
        public Task<List<DoctorTimeSlotLayered>> GetAvailableTimeSlotsAsync()
        {
            return Task.FromResult(DoctorTimeSlots.Where(d => !d.IsReserved).ToList());
        }
        public Task<bool> DoesTimeSlotExist(DateTime time)
        {
            return Task.FromResult(DoctorTimeSlots.Any(d => d.Time == time));
        }
        public async Task UpdateDoctorTimeSlotReservedStatus(Guid id)
        {
            // Search for the DoctorTimeSlot with the given id
            DoctorTimeSlotLayered doctorTimeSlot = DoctorTimeSlots.FirstOrDefault(slot => slot.Id == id);

            // If a DoctorTimeSlot with the given id was found, update its IsReserved field
            if (doctorTimeSlot != null)
            {
                doctorTimeSlot.IsReserved = true;
            }
        }
    }
}
