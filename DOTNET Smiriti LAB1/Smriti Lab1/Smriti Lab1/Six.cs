//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Smriti_Lab1
//{
//    using System;

//    namespace Smriti_Lab1
//    {
//        class Six
//        {
//            static void Main(string[] args)
//            {
//                // Get user inputs for two numbers
//                double number1 = GetDoubleFromUser("Enter the first number: ");
//                double number2 = GetDoubleFromUser("Enter the second number: ");

//                // Display numbers before swapping
//                Console.WriteLine($"\nBefore swapping:\nFirst number: {number1}\nSecond number: {number2}");

//                // Swap the numbers
//                Swap(ref number1, ref number2);

//                // Display numbers after swapping
//                Console.WriteLine($"\nAfter swapping:\nFirst number: {number1}\nSecond number: {number2}");

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
//                    if (double.TryParse(input, out result))
//                    {
//                        return result;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid input. Please enter a valid number.");
//                    }
//                }
//            }

//            // Method to swap two numbers
//            static void Swap(ref double a, ref double b)
//            {
//                double temp = a;
//                a = b;
//                b = temp;
//            }
//        }
//    }

//}
