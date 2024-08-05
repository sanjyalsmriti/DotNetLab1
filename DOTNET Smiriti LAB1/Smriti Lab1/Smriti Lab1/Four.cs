//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Smriti_Lab1
//{
//    using System;

//    namespace SimpleInterestCalculator
//    {
//        class Four
//        {
//            static void Main(string[] args)
//            {
//                // Get user inputs for principal, time, and rate
//                double principal = GetDoubleFromUser("Enter the principal amount: ");
//                double time = GetDoubleFromUser("Enter the time (in years): ");
//                double rate = GetDoubleFromUser("Enter the interest rate (as a percentage): ");

//                // Calculate simple interest
//                double simpleInterest = CalculateSimpleInterest(principal, time, rate);

//                // Display the result
//                Console.WriteLine($"\nThe simple interest is: {simpleInterest}");

//                // Wait for the user to press any key before exiting
//                Console.WriteLine("\nPress any key to exit...");
//                Console.ReadKey();
//            }

//            // Method to get a valid double value from the user
//            static double GetDoubleFromUser(string prompt)
//            {
//                double result;
//                while (true)
//                {
//                    Console.Write(prompt);
//                    string input = Console.ReadLine();

//                    // Try to parse the input to a double
//                    if (double.TryParse(input, out result) && result >= 0)
//                    {
//                        return result;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid input. Please enter a positive number.");
//                    }
//                }
//            }

//            // Method to calculate simple interest
//            static double CalculateSimpleInterest(double principal, double time, double rate)
//            {
//                return (principal * rate * time) / 100;
//            }
//        }
//    }

//}
