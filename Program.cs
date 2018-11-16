// Benjamin Thornhill
// Description: This program produces the prime numbers within a user-defined range

// This program was written solely by me with no help from anyone or resources on the internet
// Program Motivation: This program is intended for Sewell Direct for employment considerations
// Date: 11/15/2018
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bool to help 
            bool isRepeat = true;
            Console.WriteLine("This program will write to the console prime numbers in the user-defined range.");
            while (isRepeat)
            {
                // Bools to vet data from the user 
                bool isGoodData1, isGoodData2;
                // Integers to store the two ends of the range
                int lowEnd, highEnd;
                // Prompt the user for the range
                Console.WriteLine("Please enter the low-end(inclusive) of the range.");
                isGoodData1 = int.TryParse(Console.ReadLine(), out lowEnd);
                Console.WriteLine("Please enter the high-end(inclusive) of the range.");
                isGoodData2 = int.TryParse(Console.ReadLine(), out highEnd);
                // Ensure that the user-data consists of positive integers
                if(isGoodData1 && isGoodData2 & lowEnd > 0 && highEnd > 0)
                {
                    int totalPrimeNumbers = 0;
                    for (int i = lowEnd; i <= highEnd; i++)
                    {
                        if (DeterminePrime(i))
                        {
                            Console.Write($"{i}, ");
                            totalPrimeNumbers++;
                        }
                    }
                    Console.WriteLine($"\nA total of {totalPrimeNumbers} were found.");
                }
                else
                {
                    Console.WriteLine("Unacceptable data. Please try again if desired.");
                }
                // Prompt user concerning program repetition
                Console.WriteLine("Would you like to run again? ('y' or 'n')");
                string response = Console.ReadLine();
                isRepeat = DetermineRepeat(response);
            }
            // Hold the console window open
            Console.ReadKey();
        }
        // The DeterminePrime Method
        // Purpose: Returns a boolean value to determine whether or not the passed in integer is a prime number
        static bool DeterminePrime(int num)
        {
            for (int i = num/2; i > 1; i--)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        // The DetermineRepeat Method
        // Purpose: Returns a boolean value based on the passed in string to determine whether or not to repeat the program
        static bool DetermineRepeat(string response)
        {
            switch (Char.ToLower(response[0]))
            {
                case 'y':
                    return true;
                case 'n':
                    Console.WriteLine("Halting program.");
                    return false;
                default:
                    Console.WriteLine("Unrecognized input... halting program.");
                    return false;
            }
        }
    }
}
