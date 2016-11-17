//Write a program that converts a binary number N to its decimal representation.
using System;
class BinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        Console.WriteLine(ConvertBinaryToDecimal(binaryNumber));
    }

    static long ConvertBinaryToDecimal(string binaryNum) // 110011 - 1*2^0 + 1*2^1 + 0*2^2 +...
    {
        long number = 0;
        int multiplier = 1;
        for (int i = binaryNum.Length - 1; i >= 0 ; i--)
        {
            int coeficiente = binaryNum[i] == '0' ? 0 : 1;
            number += coeficiente * multiplier;
            multiplier <<= 1;
        }

        return number;
    }
}
