using Management.Shared.Events;

namespace Notification.Application.UseCases
{
    public class CreateAppointmentConfirmationEventHandler
    {
        public Task Handle(SchedulingAnAppointmentEventDto notification)
        {
            Console.Write("Notification received " + notification.SlotId);
            //throw new Exception("Can't handle the notification");
            return Task.CompletedTask;
        }
    }
}
