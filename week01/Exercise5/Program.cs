using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the functions and store their return values
        DisplayWelcome();
        
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        
        int squaredNumber = SquareNumber(userNumber);
        
        DisplayResult(userName, squaredNumber);
    }

    // Function 1: Displays a simple welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function 2: Asks for the user's name and returns it as a string
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function 3: Asks for a number, parses it, and returns it as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string response = Console.ReadLine();
        int number = int.Parse(response);
        return number;
    }

    // Function 4: Accepts an integer, calculates its square, and returns the new integer
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // Function 5: Accepts a string and an integer, and displays the final formatted output
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}