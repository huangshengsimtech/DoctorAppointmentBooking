namespace DoctorAppointmentBookingLayered.Services.Exceptions
{
    [Serializable]
    internal class DoctorNameException : Exception
    {
        public DoctorNameException() : base("Doctor name cannot be empty.")
        {
        }
    }
}
