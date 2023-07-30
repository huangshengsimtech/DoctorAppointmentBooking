namespace DoctorAppointmentBookingLayered.Services.Exceptions
{
    [Serializable]
    internal class DoctorNameExceptionLayered : Exception
    {
        public DoctorNameExceptionLayered() : base("Doctor name cannot be empty.")
        {
        }
    }
}
