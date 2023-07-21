namespace PatientBooking.Domain.Entities
{
    public class PatientAppointment
    {
        private List<DomainEvent> _domainEvents = new List<DomainEvent>();
        public Guid Id { get; private set; }
        public Guid SlotId { get; private set; }
        public Guid PatientId { get; private set; }
        public string PatientName { get; private set; }
        public DateTime ReservedAt { get; private set; }

        private PatientAppointment(Guid id, Guid slotId, Guid patientId, string patientName, DateTime reservedAt)
        {
            Id = id;
            SlotId = slotId;
            PatientId = patientId;
            PatientName = patientName;
            ReservedAt = reservedAt;
        }
        public IReadOnlyCollection<DomainEvent> GetOccuredEvents()
        {
            return _domainEvents.AsReadOnly();
        }

        public static PatientAppointment CreateNew(Guid id, Guid slotId, Guid patientId, string patientName, DateTime reservedAt)
        {
            var appointment = new PatientAppointment(id,
                slotId,
                patientId,
                patientName,
                reservedAt
            );
            appointment._domainEvents.Add(new AppointmentCreated(id, slotId, patientId));
            return appointment;
        }

        public void ChangeSlot(Guid slotId)
        {
            this.SlotId = slotId;
        }

    }
    public interface DomainEvent
    {
    }

    public record AppointmentCreated(Guid Id, Guid SlotId, Guid PatientId) : DomainEvent;

}
