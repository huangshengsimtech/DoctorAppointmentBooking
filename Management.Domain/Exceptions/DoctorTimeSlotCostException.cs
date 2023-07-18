namespace Management.Domain.Exceptions
{
    [Serializable]
    internal class DoctorTimeSlotCostException : Exception
    {
        public DoctorTimeSlotCostException() : base("Cost should be larger than zero!")
        {
        }

    }
}
