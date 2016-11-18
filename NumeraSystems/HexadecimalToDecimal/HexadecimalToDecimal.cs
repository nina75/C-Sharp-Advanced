//Write a program that converts a hexadecimal number N to its decimal representation.

using System;
class HexadecimalToDecimal
{
    static void Main()
    {
        string hexNum = Console.ReadLine();
        Console.WriteLine(ConvertHexToDecimal(hexNum));
    }

    static long ConvertHexToDecimal(string hexNum) // DE0B6B3A7640000 13 = 1 * 16^1 + 3 * 16^0
    {
        long number = 0;
        long multiplier = 1;
        for (int i = hexNum.Length - 1; i >= 0; i--)
        {
            number += GetSymbolAsNumber(hexNum[i]) * multiplier;
            multiplier <<= 4; // *=16
        }

        return number;
    }

    static int GetSymbolAsNumber(char symbol)
    {
        char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        return Array.IndexOf(symbols, symbol);
    }
}
