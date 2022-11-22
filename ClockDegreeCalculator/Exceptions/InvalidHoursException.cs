namespace ClockDegreeCalculator.Exceptions
{
    public class InvalidHoursException : Exception
    {
        public InvalidHoursException(int hours) : base($"The specified value {hours} in hours does not match for the clock dial") { }
    }
}
