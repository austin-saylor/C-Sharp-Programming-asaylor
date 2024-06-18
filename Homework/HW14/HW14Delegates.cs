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

    public static void ActionDemo()
    {
        Action<string> PrintMessage = message => Console.WriteLine(message);
        PrintMessage("Hello from Action!");
    }

    public static void PredicateDemo()
    {
        Predicate<int> IsEven = number => number % 2 == 0;
        bool result = IsEven(4);
        Console.WriteLine($"Predicate result: {result}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Start the program
        Console.WriteLine("Circle Calculation Demo:\n");

        // Define the multi-cast delegate
        CircleCalc calculate = new CircleCalc();
        CircleDelegate circleDelegate = calculate.CircleArea;
        circleDelegate += calculate.Circumference;

        // Ask the user for a radius
        double radius = 0;
        bool isValidInput = false;

        while (!isValidInput)
        {
            Console.Write("Please enter a radius: ");
            string userInput = Console.ReadLine();

            if (double.TryParse(userInput, out radius))
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("The input is not a valid double. Please try again.");
            }
        }

        // Use the delegate to call the calculation methods using the given radius
        circleDelegate(radius);

        // Func Example
        DelegateTypes.FuncDemo();

        // Action Example
        DelegateTypes.ActionDemo();

        // Predicate Example
        DelegateTypes.PredicateDemo();
    }
}
