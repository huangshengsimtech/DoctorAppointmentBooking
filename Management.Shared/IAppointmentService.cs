using Management.Domain.Entities;

namespace Management.Shared
{
    public interface IAppointmentService
    {
        public Task Create(Appointment appointment);
    }
}
