namespace DoctorAppointmentBooking.Services.Exceptions
{
    [Serializable]
    internal class DoctorTimeSlotException : Exception
    {
        public DoctorTimeSlotException() : base("Doctor name should not be null!")
        {
        }
    }
}
