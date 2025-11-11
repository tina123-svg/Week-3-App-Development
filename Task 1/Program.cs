using System;
public class Program
{
    static void Main(String[] args)
    {
        Operator ops = new Operator();

        ops.Add(10, 2);
        ops.Subtract(10, 2);
        ops.Multiply(10, 2);
        ops.Divide(10, 2);
        ops.OddEvenFinder(10);
    }
}