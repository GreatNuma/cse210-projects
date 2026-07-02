using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter = "";

        // Core Requirement: Determine the letter grade
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

        // Stretch Challenge: Determine the sign (+ or -)
        string sign = "";
        int lastDigit = percent % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Stretch Challenge: Handle edge cases for 100%, A+, F+, and F-
        if (percent >= 100) 
        {
            // Prevents 100 from becoming A- (since 100 % 10 = 0, which is < 3)
            sign = ""; 
        }
        else if (letter == "A" && sign == "+")
        {
            // Recognize there is no A+ grade
            sign = "";
        }
        else if (letter == "F")
        {
            // Recognize there are no F+ or F- grades
            sign = "";
        }

        // Core Requirement: Single print statement for the combined letter and sign
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Core Requirement: Separate if statement for the pass/fail message
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep trying and you'll get it next time.");
        }
    }
}