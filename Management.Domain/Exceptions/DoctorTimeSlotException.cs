namespace Management.Domain.Exceptions
{
    [Serializable]
    public class DoctorTimeSlotException : Exception
    {
        public DoctorTimeSlotException() : base("This time slot already exists.")
        {
        }
    }
}
