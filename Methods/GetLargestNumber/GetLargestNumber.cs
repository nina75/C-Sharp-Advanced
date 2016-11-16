using System;
using System.Linq;

class GetLargestNumber
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(x => int.Parse(x))
            .ToArray();
        Console.WriteLine(GetMax(numbers));
    }

    static int GetMax(params int[] numbers)
    {
        return numbers.Max();
    }
}
