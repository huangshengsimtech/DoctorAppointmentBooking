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
        public  Task UpdateDoctorTimeSlotReservedStatus(Guid id)
        {
            // This is a dummy function for compiling purposes.
            return Task.FromResult(DoctorTimeSlots.Any(d => d.Id == id));

        }
    }

}
