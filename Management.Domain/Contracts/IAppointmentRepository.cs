using Management.Domain.Entities;

namespace Management.Domain.Repositories
{
    public interface IAppointmentRepository
    {
        public Task Add(Appointment appointment);
    }
}
