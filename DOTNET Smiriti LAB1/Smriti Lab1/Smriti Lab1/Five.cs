//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Smriti_Lab1
//{
//    using System;

//    namespace ArithmeticOperations
//    {
//        class Five
//        {
//            static void Main(string[] args)
//            {
//                // Get user inputs for two numbers and an operator
//                double number1 = GetDoubleFromUser("Enter the first number: ");
//                double number2 = GetDoubleFromUser("Enter the second number: ");
//                char operation = GetOperationFromUser("Enter the operation (+, -, *, /): ");

//                // Perform the operation and display the result
//                double result = PerformOperation(number1, number2, operation);
//                Console.WriteLine($"\nThe result of {number1} {operation} {number2} is: {result}");

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

//            // Method to get a valid operation from the user
//            static char GetOperationFromUser(string prompt)
//            {
//                char operation;
//                while (true)
//                {
//                    Console.Write(prompt);
//                    string input = Console.ReadLine();

//                    // Check if the input is a single character and a valid operator
//                    if (input.Length == 1 && "+-*/".Contains(input))
//                    {
//                        operation = input[0];
//                        return operation;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid input. Please enter a valid operator (+, -, *, /).");
//                    }
//                }
//            }

//            // Method to perform the arithmetic operation
//            static double PerformOperation(double number1, double number2, char operation)
//            {
//                switch (operation)
//                {
//                    case '+':
//                        return number1 + number2;
//                    case '-':
//                        return number1 - number2;
//                    case '*':
//                        return number1 * number2;
//                    case '/':
//                        if (number2 != 0)
//                        {
//                            return number1 / number2;
//                        }
//                        else
//                        {
//                            Console.WriteLine("Error: Division by zero is not allowed.");
//                            return double.NaN; // Not-a-Number (NaN) to indicate an error
//                        }
//                    default:
//                        throw new InvalidOperationException("Invalid operation");
//                }
//            }
//        }
//    }

//}
