using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop to gather input until the user types 0
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);

            // Ensure 0 is not added to the list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Initialize variables for computation
        int sum = 0;
        int max = numbers[0]; // Assuming the user enters at least one valid number
        int smallestPositive = int.MaxValue; 

        // Core & Stretch Requirement: Iterate through the list once to calculate everything
        foreach (int number in numbers)
        {
            sum += number; // Core: Sum

            if (number > max)
            {
                max = number; // Core: Maximum
            }

            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number; // Stretch: Smallest Positive
            }
        }

        // Core Requirement: Average
        // Cast the sum to a double to get floating-point division instead of integer division
        double average = ((double)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge: Display smallest positive only if one was found
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Stretch Challenge: Sort the list and display
        numbers.Sort();
        
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}