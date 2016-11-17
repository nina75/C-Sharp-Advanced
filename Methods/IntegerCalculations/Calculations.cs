// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments. Write a program
// that reads 5 elements and prints their minimum, maximum, average, sum and product.

using System;
using System.Linq;
using System.Numerics;

class Calculations
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        Console.WriteLine(Min(numbers));
        Console.WriteLine(Max(numbers));
        Console.WriteLine("{0:0.00}", Avg(numbers));
        Console.WriteLine(Sum(numbers));
        Console.WriteLine(Product(numbers));
    }

    static int Min(params int[] numbers)
    {
        return numbers.Min();
    }

    static int Max(params int[] numbers)
    {
        return numbers.Max();
    }

    static double Avg(params int[] numbers)
    {
        return numbers.Average();
    }

    static int Sum(params int[] numbers)
    {
        return numbers.Sum();
    }

    static BigInteger Product(params int[] numbers)
    {
        BigInteger product = 1;
        foreach (var num in numbers)
        {
            product *= num;
        }
        return product;
    }
}
