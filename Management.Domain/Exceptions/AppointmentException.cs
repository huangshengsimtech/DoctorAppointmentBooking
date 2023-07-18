namespace Management.Domain.Exceptions
{
    [Serializable]
    internal class AppointmentException : Exception
    {
        public AppointmentException() : base("Patient name should not be null!")
        {
        }
    }
}
