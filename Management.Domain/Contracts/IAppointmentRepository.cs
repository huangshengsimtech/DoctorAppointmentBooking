using Management.Domain.Entities;

namespace Management.Domain.Contracts
{
    public interface IAppointmentRepository
    {
        public Task Add(Appointment appointment);
    }
}
