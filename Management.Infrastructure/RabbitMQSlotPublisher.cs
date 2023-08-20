using Convey.MessageBrokers;
using Management.Shared.Events;
using Management.Application.Dtos;
using Management.Application.Contracts;

namespace Management.Infrastructure
{
    public class RabbitMQSlotPublisher : ISlotPublisher
    {
        private readonly IBusPublisher _publisher;

        public RabbitMQSlotPublisher(IBusPublisher publisher)
        {
            _publisher = publisher;
        }

        public async Task Publish(DoctorTimeSlotModified @event)
        {
            await _publisher.PublishAsync(new SchedulingAnAppointmentEventDto(@event.SlotId));
        }
    }
}
