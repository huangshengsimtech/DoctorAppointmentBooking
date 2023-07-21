using System.ComponentModel.DataAnnotations;

namespace Management.Domain.Entities
{
    public class DoctorTimeSlot
    {
        private List<DomainEvent> _domainEvents = new List<DomainEvent>();

        public Guid Id { get; private set; }
        public DateTime Time { get; private set; }
        public Guid DoctorId { get; private set; }
        public string DoctorName { get; private set; }
        public bool IsReserved { get; set; }
        public decimal Cost { get; private set; }
        private DoctorTimeSlot(Guid id, DateTime time, Guid doctorId, string doctorName, bool isReserved, decimal cost)
        {
            Id = id;
            Time = time;
            DoctorId = doctorId;
            DoctorName = doctorName;
            IsReserved = isReserved;
            Cost = cost;
        }
        public IReadOnlyCollection<DomainEvent> GetOccuredEvents()
        {
            return _domainEvents.AsReadOnly();
        }

        public static DoctorTimeSlot CreateNew(Guid id, DateTime time, Guid doctorId, string doctorName, bool isReserved, decimal cost)
        {
            var doctorTimeSlot = new DoctorTimeSlot(id,
                time,
                doctorId,
                doctorName,
                isReserved,
                cost
            );
            doctorTimeSlot._domainEvents.Add(new DoctorTimeSlotCreated(id, doctorId));
            return doctorTimeSlot;
        }
        public void ChangeDoctor(Guid doctorId)
        {
            this.DoctorId = doctorId;
        }

    }
    public interface DomainEvent
    {
    }

    public record DoctorTimeSlotCreated(Guid Id, Guid DoctorId) : DomainEvent;

}
