//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        string binaryNum = Console.ReadLine();
        Console.WriteLine(ConvertBinToHex(binaryNum));
    }

    static string ConvertBinToHex(string binNum)
    {
        var hexNum = new StringBuilder();
        var hexToBinaryTable = new Dictionary<string, char>
        {
            { "0000", '0'},
            { "0001", '1'},
            { "0010", '2'},
            { "0011", '3'},
            { "0100", '4'},
            { "0101", '5'},
            { "0110", '6'},
            { "0111", '7'},
            { "1000", '8'},
            { "1001", '9'},
            { "1010", 'A'},
            { "1011", 'B'},
            { "1100", 'C'},
            { "1101", 'D'},
            { "1110", 'E'},
            { "1111", 'F'},
                
        };
        if (binNum.Length % 4 != 0)
        {
            binNum = binNum.PadLeft(binNum.Length + (4 - binNum.Length % 4), '0');
        }
        for (int i = 0; i < binNum.Length; i += 4)
        {
            string current = binNum.Substring(i, 4);
            hexNum.Append(hexToBinaryTable[current]);
        }

        return hexNum.ToString();
    }
}
