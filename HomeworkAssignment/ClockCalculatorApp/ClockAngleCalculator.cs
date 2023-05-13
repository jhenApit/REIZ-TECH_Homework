using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssignment.ClockCalculatorApp
{
    public class ClockAngleCalculator
    {
        private readonly Clock _clock;

        public ClockAngleCalculator(Clock clock)
        {
            _clock = clock;
        }

        public int CalculateLesserAngle()
        {
            // the hour hand moves 30 degrees per hour and 0.5 degrees per minute
            int hourHandDegrees = 30 * _clock.Hours + _clock.Minutes / 2;

            // the minute hand moves 6 degrees per minute
            int minHandDegrees = _clock.Minutes * 6;

            // the angle between the hands is the absolute value of the difference between the two angles
            int angle = Math.Abs(hourHandDegrees - minHandDegrees);

            // return the lesser angle between the two possible angles
            return Math.Min(angle, 360 - angle);
        }
    }
}
