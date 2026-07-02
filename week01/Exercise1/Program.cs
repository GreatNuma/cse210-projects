using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Prompt the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Add a blank line for formatting consistency with the example
        Console.WriteLine();

        // Output the formatted string exactly as requested
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}