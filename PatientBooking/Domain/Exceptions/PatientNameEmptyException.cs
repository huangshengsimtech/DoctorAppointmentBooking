namespace PatientBooking.Domain.Exceptions
{
    [Serializable]
    internal class PatientNameEmptyException : Exception
    {
        public PatientNameEmptyException() : base("Patient name should not be empty!")
        {
        }
    }

}
