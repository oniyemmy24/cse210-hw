using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();

        int percent = int.Parse(answer);
        bool isValid = int.TryParse(answer, out percent);

        if (!isValid|| percent < 0 || percent > 100)
        {
            Console.WriteLine("Invalid input. Please enter a percent between 0 and 100");
            return;
        }

        string letter = "";
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

            Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
            
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}