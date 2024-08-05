//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Smriti_Lab1
//{
//    using System;

//    namespace MultiplicationTable
//    {
//        class Seven
//        {
//            static void Main(string[] args)
//            {
//                // Get the number from the user
//                int number = GetIntegerFromUser("Enter a number to print its multiplication table: ");

//                // Display the multiplication table
//                PrintMultiplicationTable(number);

//                // Wait for the user to press any key before exiting
//                Console.WriteLine("\nPress any key to exit...");
//                Console.ReadKey();
//            }

//            // Method to get a valid integer value from the user
//            static int GetIntegerFromUser(string prompt)
//            {
//                int result;
//                while (true)
//                {
//                    Console.Write(prompt);
//                    string input = Console.ReadLine();

//                    // Try to parse the input to an integer
//                    if (int.TryParse(input, out result))
//                    {
//                        return result;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid input. Please enter a valid integer.");
//                    }
//                }
//            }

//            // Method to print the multiplication table for a given number
//            static void PrintMultiplicationTable(int number)
//            {
//                Console.WriteLine($"\nMultiplication Table for {number}:");
//                for (int i = 1; i <= 10; i++)
//                {
//                    int result = number * i;
//                    Console.WriteLine($"{number} x {i} = {result}");
//                }
//            }
//        }
//    }

//}
