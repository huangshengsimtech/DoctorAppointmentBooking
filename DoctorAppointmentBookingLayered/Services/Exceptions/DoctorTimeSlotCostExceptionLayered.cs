namespace DoctorAppointmentBookingLayered.Services.Exceptions
{
    [Serializable]
    internal class DoctorTimeSlotCostExceptionLayered : Exception
    {
        public DoctorTimeSlotCostExceptionLayered() : base("Cost should be larger than zero!")
        {
        }

    }
}
