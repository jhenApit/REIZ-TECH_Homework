using HomeworkAssignment.ClockCalculatorApp;

namespace HomeworkAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the time in the format of 'hh:mm' :");
            string[] timeParts = Console.ReadLine()!.Split(':');

            int hours = int.Parse(timeParts[0]);
            int minutes = int.Parse(timeParts[1]);
            Console.WriteLine("\n-----------------------------------------");

            var clock = new Clock(hours, minutes);
            var calculator = new ClockAngleCalculator(clock);

            Console.WriteLine($"The angle between the hour and minute hands is: {calculator.CalculateLesserAngle()} degrees");
        }
    }
}