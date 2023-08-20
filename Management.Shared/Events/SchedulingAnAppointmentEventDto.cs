using Convey.MessageBrokers;

namespace Management.Shared.Events
{
    [Message("timeslots", "timeslots.slotAdded", "scheduling.slotAdded")]
    public record SchedulingAnAppointmentEventDto(Guid SlotId);
}
