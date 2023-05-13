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
            int hourHandDegrees = 30 * _clock.Hours + _clock.Minutes / 2;
            int minHandDegrees = _clock.Minutes * 6;

            int angle = Math.Abs(hourHandDegrees - minHandDegrees);
            return Math.Min(angle, 360 - angle);
        }
    }
}
