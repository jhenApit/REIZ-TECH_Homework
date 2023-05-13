using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssignment.ClockCalculatorApp
{
    public class Clock
    {
        public int Hours { get; }
        public int Minutes { get; }

        public Clock(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }
    }
}
