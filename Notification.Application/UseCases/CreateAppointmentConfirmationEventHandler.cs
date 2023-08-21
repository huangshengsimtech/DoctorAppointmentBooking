using Management.Shared.Events;
using Notification.Domain.Entities;
using Serilog;

namespace Notification.Application.UseCases
{
    public class CreateAppointmentConfirmationEventHandler
    {
        public Task Handle(SchedulingAnAppointmentEventDto notification)
        {
            Log.Information("Hello, the appointment has been confirmed!");
            Log.Information("Appointment created for SlotId: {SlotId}", notification.SlotId);

            Console.Write("Notification received " + notification.SlotId);
            //throw new Exception("Can't handle the notification");
            return Task.CompletedTask;
        }
    }
}
