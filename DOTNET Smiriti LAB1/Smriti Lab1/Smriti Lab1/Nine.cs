using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smriti_Lab1
{
    using System;

    namespace Smriti_Lab1
    {
        class Nine
        {
           static void Main(string[] args)
            {
                // Get the input number from the user
                int number = GetIntegerFromUser("Enter a number to check if it is odd or even: ");

                // Determine if the number is odd or even
                if (IsEven(number))
                {
                    Console.WriteLine($"{number} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd number.");
                }

                // Wait for the user to press any key before exiting
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }

            // Method to get a valid integer value from the user
            static int GetIntegerFromUser(string prompt)
            {
                int result;
                while (true)
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine();

                    // Try to parse the input to an integer
                    if (int.TryParse(input, out result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }
            }

            // Method to check if a number is even
            static bool IsEven(int number)
            {
                return number % 2 == 0;
            }
        }
    }

}
