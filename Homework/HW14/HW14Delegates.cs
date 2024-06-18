using System;

// CircleCalculations class to calculate area and circumference of a circle
public class CircleCalc
{
    public void CircleArea(double radius)
    {
        double area = Math.PI * radius * radius;
        area = Math.Round(area, 2);
        Console.WriteLine($"\nArea = {area}");
    }

    public void Circumference(double radius)
    {
        double circumference = 2 * Math.PI * radius;
        circumference = Math.Round(circumference, 2);
        Console.WriteLine($"Circumference = {circumference}");
    }
}

// Delegate to handle circle calculations
public delegate void CircleDelegate(double radius);

public class DelegateTypes
{
    public static void FuncDemo()
    {
        Func<int, int, int> Add = (a, b) => a + b;
        int result = Add(3, 4);
        Console.WriteLine($"\nFunc: 3 + 4 = {result}");
        Console.WriteLine($"{result} was the result of that addition operation.");
    }

    public static void ActionDemo(string line)
    {
        Console.WriteLine($"Action: {line}");
    }

    public static bool PredicateDemo(int num)
    {
        bool result = (num % 10 == 0);
        Console.WriteLine($"\nPredicate result: {result}");
        if (result == false)
        {
            Console.WriteLine($"The given number is not divisible by 10.");
        }
        else
        {
            Console.WriteLine($"The given number is divisible by 10.");
        }
        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Start the program
        Console.WriteLine("Delegates Demo:\n");
        Console.WriteLine("Circle Calculations:\n");

        // Define the multi-cast delegate
        CircleCalc calculate = new CircleCalc();
        CircleDelegate circleDelegate = calculate.CircleArea;
        circleDelegate += calculate.Circumference;

        // Ask the user for a radius
        double radius = 0;
        bool isValidDouble = false;

        while (!isValidDouble)
        {
            Console.Write("Please enter a radius: ");
            string userInput = Console.ReadLine();

            if (double.TryParse(userInput, out radius))
            {
                isValidDouble = true;
            }
            else
            {
                Console.WriteLine("The input is not a valid double. Please try again.");
            }
        }

        // Use the delegate to call the calculation methods using the given radius
        circleDelegate(radius);

        // Transition to demonstrating built-in Delegate Types:
        Console.WriteLine("\n\nBuilt-In Types Demo:");

        // Func Example
        DelegateTypes.FuncDemo();

        // Action Example
        Action<string> PrintMessage = DelegateTypes.ActionDemo;
        Console.Write("\nPlease enter a string to be used in the Action Demo: ");
        string line = Console.ReadLine();
        PrintMessage(line);

        // Predicate Example
        Predicate<int> DivisibleByTen = DelegateTypes.PredicateDemo;
        int num = 0;
        bool isValidInt = false;

        while (!isValidInt)
        {
            Console.Write("\nPlease enter a number to be used for the Predicate Demo: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out num))
            {
                isValidInt = true;
            }
            else
            {
                Console.WriteLine("The input is not a valid integer. Please try again.");
            }
        }
        DivisibleByTen(num);
    }
}