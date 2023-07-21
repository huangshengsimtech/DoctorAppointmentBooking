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
