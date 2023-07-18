namespace Management.Domain.Exceptions
{
    [Serializable]
    public class DoctorNameException : Exception
    {
        public DoctorNameException() : base("Doctor name cannot be empty.")
        {
        }
    }
}
