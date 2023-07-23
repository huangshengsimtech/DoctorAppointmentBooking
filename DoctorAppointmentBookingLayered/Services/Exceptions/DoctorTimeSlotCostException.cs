namespace DoctorAppointmentBookingLayered.Services.Exceptions
{
    [Serializable]
    internal class DoctorTimeSlotCostException : Exception
    {
        public DoctorTimeSlotCostException() : base("Cost should be larger than zero!")
        {
        }

    }
}
