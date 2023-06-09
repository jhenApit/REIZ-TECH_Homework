﻿using HomeworkAssignment.ClockCalculatorApp;
using HomeworkAssignment.DepthCalculatorApp;

namespace HomeworkAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine(
                "Please Select a Program:" +
                "\na. Analog Clock Angle Calculator" +
                "\nb. Recursive Structure Depth Calculator");

            Console.WriteLine("\n-----------------------------------------");

            var input = Console.ReadLine();

            switch (input)
            {
                case "a":
                    ClockAngleCalculatorApp();
                    break;
                case "b":
                    BranchDepthCalculatorApp();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    Run();
                    break;

            }
        }

        private static void ClockAngleCalculatorApp()
        {
            Console.WriteLine("Please enter the time in the format of 'hh:mm' :");
            // get input from user and split it into hours and minutes
            string[] timeParts = Console.ReadLine()!.Split(':');

            // parse the hours and minutes into integers
            int hours = int.Parse(timeParts[0]);
            int minutes = int.Parse(timeParts[1]);
            Console.WriteLine("\n-----------------------------------------");

            // create a new clock and calculator
            var clock = new Clock(hours, minutes);
            var calculator = new ClockAngleCalculator(clock);

            Console.WriteLine($"The angle between the hour and minute hands is: {calculator.CalculateLesserAngle()} degrees.");
        }

        private static void BranchDepthCalculatorApp()
        {
            // create the Root of a recursive structure
            Branch root = new Branch();
            root.branches = new List<Branch>();

            // add some branches
            Branch child1 = new Branch();
            child1.branches = new List<Branch>();
            root.branches.Add(child1);

            Branch child2 = new Branch();
            root.branches.Add(child2);

            // add sub-branches
            Branch grandchild1 = new Branch();
            grandchild1.branches = new List<Branch>();
            child1.branches.Add(grandchild1);

            Console.WriteLine($"The depth of this structure is: {BranchDepthCalculator.CalculateDepth(root)}.");
        }
    }
}