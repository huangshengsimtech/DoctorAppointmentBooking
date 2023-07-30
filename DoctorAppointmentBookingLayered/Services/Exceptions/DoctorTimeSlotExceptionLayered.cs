namespace DoctorAppointmentBookingLayered.Services.Exceptions
{
    [Serializable]
    internal class DoctorTimeSlotExceptionLayered : Exception
    {
        public DoctorTimeSlotExceptionLayered() : base("This time slot already exists.")
        {
        }
    }
}
