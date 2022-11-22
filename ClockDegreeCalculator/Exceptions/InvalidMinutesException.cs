namespace ClockDegreeCalculator.Exceptions
{
    public class InvalidMinutesException : Exception
    {
        public InvalidMinutesException(int minutes) : base($"The specified value {minutes} in minutes does not match for the clock dial") { }
    }
}
