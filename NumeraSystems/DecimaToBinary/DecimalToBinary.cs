//Write a program that converts a decimal number N to its binary representation.
using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine()); //19
        Console.WriteLine(ConvertDecimalToBinary(number));
    }

    static string ConvertDecimalToBinary(long number)
    {
        var bits = new List<long>();
        while (number > 0)
        {
            bits.Add(number % 2);
            number /= 2;
        }

        long[] bitsArray = bits.ToArray();
        Array.Reverse(bitsArray);
        return String.Join("", bitsArray);
    }
}
