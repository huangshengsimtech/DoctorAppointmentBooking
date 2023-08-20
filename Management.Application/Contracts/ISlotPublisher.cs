using Management.Application.Dtos;

namespace Management.Application.Contracts
{
    public interface ISlotPublisher
    {
        Task Publish(DoctorTimeSlotModified doctorTimeSlotModified);
    }
}
