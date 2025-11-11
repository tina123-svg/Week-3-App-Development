public class Operator
{
    public void Add(int a, int b)
    {
        Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
    }

    public void Subtract(int a, int b)
    {
        Console.WriteLine($"The difference of {a} and {b} is: {a - b}");

    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine($"The product of {a} and {b} is: {a * b}");
    }

    public void Divide(int a, int b)
    {
        Console.WriteLine($"The division of {a} and {b} is: {a / b}");
    }

    public void OddEvenFinder(int number)
    {
        string result = (number % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine(result);
    }
}