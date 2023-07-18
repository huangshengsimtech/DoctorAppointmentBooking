using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management.Domain.Contracts;
using Management.Domain.Entities;


namespace Management.Infrastructure.Repositories
{
    public class AppointmentInMemoryRepo : IAppointmentRepository
    {
        private static readonly List<Appointment> Appointments = new();

        public async Task Add(Appointment appointment)
        {
            Appointments.Add(appointment);
        }

        public Task<Appointment?> GetById(Guid id)
        {
            return Task.FromResult(Appointments.SingleOrDefault(x => x.Id == id));
        }
    }
}
