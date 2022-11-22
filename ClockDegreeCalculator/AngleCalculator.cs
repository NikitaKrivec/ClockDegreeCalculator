using ClockDegreeCalculator.Exceptions;

namespace ClockDegreeCalculator
{
    public class AngleCalculator
    {
        public double GetAngleCalculator(int hours, int minutes)
        {
            if (hours < 0 || hours > 12)
            {
                throw new InvalidHoursException(hours);
            }

            if (minutes < 0 || minutes > 60) 
            {
                throw new InvalidMinutesException(minutes);
            }
            
            if (hours == 12)
            {
                hours = 0;
            }

            if (minutes == 60)
            {
                minutes = 0;
            }

            double hourAngle = (0.5 * (hours * 60 + minutes));
            double minuteAngle = (6 * minutes);

            double angle = Math.Abs(hourAngle - minuteAngle);
            angle = Math.Min(360 - angle, angle);

            return angle;
        }
    }
}
