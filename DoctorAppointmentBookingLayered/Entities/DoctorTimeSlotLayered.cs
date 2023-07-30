using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentBookingLayered.Entities
{
    public class DoctorTimeSlotLayered
    {
        [Required] public Guid Id { get; set; }
        [Required] public DateTime Time { get; set; }
        [Required] public Guid DoctorId { get; set; }
        [Required] public string DoctorName { get; set; }
        [Required] public bool IsReserved { get; set; }
        [Required][Range(0.0, 1000000000.0)] public decimal Cost { get; set; }
    }

    //public class DoctorTimeSlotLayered
    //{
    //    private List<DomainEvent> _domainEvents = new List<DomainEvent>();

    //    public Guid Id { get; private set; }
    //    public DateTime Time { get; private set; }
    //    public Guid DoctorId { get; private set; }
    //    public string DoctorName { get; private set; }
    //    public bool IsReserved { get; set; }
    //    public decimal Cost { get; private set; }
    //    private DoctorTimeSlotLayered(Guid id, DateTime time, Guid doctorId, string doctorName, bool isReserved, decimal cost)
    //    {
    //        Id = id;
    //        Time = time;
    //        DoctorId = doctorId;
    //        DoctorName = doctorName;
    //        IsReserved = isReserved;
    //        Cost = cost;
    //    }
    //    public IReadOnlyCollection<DomainEvent> GetOccuredEvents()
    //    {
    //        return _domainEvents.AsReadOnly();
    //    }

    //    public static DoctorTimeSlotLayered CreateNew(Guid id, DateTime time, Guid doctorId, string doctorName, bool isReserved, decimal cost)
    //    {
    //        var doctorTimeSlot = new DoctorTimeSlotLayered(id,
    //            time,
    //            doctorId,
    //            doctorName,
    //            isReserved,
    //            cost
    //        );
    //        doctorTimeSlot._domainEvents.Add(new DoctorTimeSlotCreated(id, doctorId));
    //        return doctorTimeSlot;
    //    }
    //    public void ChangeDoctor(Guid doctorId)
    //    {
    //        this.DoctorId = doctorId;
    //    }

    //}
    //public interface DomainEvent
    //{
    //}

    //public record DoctorTimeSlotCreated(Guid Id, Guid DoctorId) : DomainEvent;

}
