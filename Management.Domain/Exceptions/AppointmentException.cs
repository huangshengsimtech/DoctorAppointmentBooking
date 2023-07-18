namespace Management.Domain.Exceptions
{
    [Serializable]
    public class AppointmentException : Exception
    {
        public AppointmentException() : base("Patient name should not be null!")
        {
        }
    }
}
