using System;

// CircleCalculations class to calculate area and circumference of a circle
public class CircleCalculations
{
    public double CalculateArea(double radius)
    {
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area: {area}");
        return area;
    }

    public double CalculateCircumference(double radius)
    {
        double circumference = 2 * Math.PI * radius;
        Console.WriteLine($"Circumference: {circumference}");
        return circumference;
    }
}

// Delegate to handle circle calculations
public delegate void CircleDelegate(double radius);

// Func example class
public class FuncExample
{
    public Func<int, int, int> Add = (a, b) => a + b;

    public void ShowFuncExample()
    {
        int result = Add(3, 4);
        Console.WriteLine($"Func result: {result}");
    }
}

// Action example class
public class ActionExample
{
    public Action<string> PrintMessage = message => Console.WriteLine(message);

    public void ShowActionExample()
    {
        PrintMessage("Hello from Action!");
    }
}

// Predicate example class
public class PredicateExample
{
    public Predicate<int> IsEven = number => number % 2 == 0;

    public void ShowPredicateExample()
    {
        bool result = IsEven(4);
        Console.WriteLine($"Predicate result: {result}");
    }
}

// Main program class
public class Program
{
    public static void Main(string[] args)
    {
        // CircleCalculations Example
        CircleCalculations calculations = new CircleCalculations();
        CircleDelegate circleDelegate = calculations.CalculateArea;
        circleDelegate += calculations.CalculateCircumference;
        ExecuteDelegate(circleDelegate, 5.0);

        // Func Example
        FuncExample funcExample = new FuncExample();
        funcExample.ShowFuncExample();

        // Action Example
        ActionExample actionExample = new ActionExample();
        actionExample.ShowActionExample();

        // Predicate Example
        PredicateExample predicateExample = new PredicateExample();
        predicateExample.ShowPredicateExample();
    }

    public static void ExecuteDelegate(CircleDelegate circleDelegate, double radius)
    {
        foreach (CircleDelegate singleDelegate in circleDelegate.GetInvocationList())
        {
            var result = singleDelegate.Method.Invoke(singleDelegate.Target, new object[] { radius });
            Console.WriteLine($"{singleDelegate.Method.Name} result: {result}");
        }
    }
}
