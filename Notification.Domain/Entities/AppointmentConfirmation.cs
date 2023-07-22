namespace Notification.Domain.Entities
{
    public class AppointmentConfirmation
    {
        private List<DomainEvent> _domainEvents = new List<DomainEvent>();
        public Guid SlotId { get; private set; }
        public Guid DoctorId { get; private set; }
        public Guid PatientId { get; private set; }
        public string DoctorName { get; private set; }
        public string PatientName { get; private set; }
        public DateTime Time { get; private set; }

        private AppointmentConfirmation(Guid slotId, 
                                        Guid doctorId, 
                                        Guid patientId, 
                                        string doctorName, 
                                        string patientName, 
                                        DateTime time)
        {
            SlotId = slotId;
            DoctorId = doctorId;
            PatientId = patientId;
            DoctorName = doctorName;
            PatientName = patientName;
            Time = time;
        }

        public IReadOnlyCollection<DomainEvent> GetOccuredEvents()
        {
            return _domainEvents.AsReadOnly();
        }

        public static AppointmentConfirmation CreateNew(Guid slotId,
                                        Guid doctorId,
                                        Guid patientId,
                                        string doctorName,
                                        string patientName,
                                        DateTime time)
        {
            var appointmentConfirmation = new AppointmentConfirmation(
                slotId,
                doctorId,
                patientId,
                doctorName,
                patientName,
                time
            );
            appointmentConfirmation._domainEvents.Add(new AppointmentConfirmationCreated(slotId, doctorId, patientId));
            return appointmentConfirmation;
        }
        public interface DomainEvent
        {
        }
        public record AppointmentConfirmationCreated(Guid SlotId, Guid DoctorId, Guid PatientId) : DomainEvent;

    }

}
