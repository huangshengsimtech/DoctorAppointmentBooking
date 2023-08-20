namespace Management.Application.Dtos
{
    public class DoctorTimeSlotModified
    {
        public DoctorTimeSlotModified(Guid id)
        {
            this.SlotId = id;
        }

        public Guid SlotId { get; set; }
    }
}
