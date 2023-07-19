using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management.Domain.Contracts;
using Management.Domain.Entities;


namespace Management.Infrastructure.Repositories
{
    public class DoctorTimeSlotInMemoryRepo : IDoctorTimeSlotRepository
    {
        private static readonly List<DoctorTimeSlot> DoctorTimeSlots = new();

        public async Task Add(DoctorTimeSlot doctorTimeSlot)
        {
            DoctorTimeSlots.Add(doctorTimeSlot);
        }

        public Task<DoctorTimeSlot?> GetById(Guid id)
        {
            return Task.FromResult(DoctorTimeSlots.SingleOrDefault(x => x.Id == id));
        }
        public  Task<List<DoctorTimeSlot>> GetByDoctorIdAsync(Guid doctorId)
        {
            return Task.FromResult(DoctorTimeSlots.Where(d => d.DoctorId == doctorId).ToList());
        }
        public  Task<List<DoctorTimeSlot>> GetAvailableTimeSlotsAsync()
        {
            return Task.FromResult(DoctorTimeSlots.Where(d => !d.IsReserved).ToList());
        }
        public  Task<bool> DoesTimeSlotExist(DateTime time)
        {
            return Task.FromResult(DoctorTimeSlots.Any(d => d.Time == time));
        }
        public async Task UpdateDoctorTimeSlotReservedStatus(Guid id)
        {
            // Search for the DoctorTimeSlot with the given id
            DoctorTimeSlot doctorTimeSlot = DoctorTimeSlots.FirstOrDefault(slot => slot.Id == id);

            // If a DoctorTimeSlot with the given id was found, update its IsReserved field
            if (doctorTimeSlot != null)
            {
                doctorTimeSlot.IsReserved = true;
            }
        }
    }
}
