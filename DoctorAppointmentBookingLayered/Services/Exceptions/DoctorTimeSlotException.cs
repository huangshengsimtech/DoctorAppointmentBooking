namespace DoctorAppointmentBookingLayered.Services.Exceptions
{
    [Serializable]
    internal class DoctorTimeSlotException : Exception
    {
        public DoctorTimeSlotException() : base("This time slot already exists.")
        {
        }
    }
}
