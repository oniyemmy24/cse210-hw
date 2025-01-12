using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
 List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            
            // Validate input
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }

            // Stop when the user enters 0
            if (number == 0)
                break;

            // Add the number to the list
            numbers.Add(number);
        }

        // Ensure the list is not empty before performing operations
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
        }
        else
        {
            // Core requirements
            int sum = CalculateSum(numbers);
            double average = CalculateAverage(numbers);
            int max = FindMaximum(numbers);

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
        }
    }

    // Function to calculate the sum of a list
    static int CalculateSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    // Function to calculate the average of a list
    static double CalculateAverage(List<int> numbers)
    {
        int sum = CalculateSum(numbers);
        return (double)sum / numbers.Count;
    }

    // Function to find the maximum value in a list
    static int FindMaximum(List<int> numbers)
    {
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }
}