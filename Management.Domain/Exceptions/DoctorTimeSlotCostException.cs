namespace Management.Domain.Exceptions
{
    [Serializable]
    public class DoctorTimeSlotCostException : Exception
    {
        public DoctorTimeSlotCostException() : base("Cost should be larger than zero!")
        {
        }

    }
}
