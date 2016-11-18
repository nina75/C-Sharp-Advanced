//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string hexNum = Console.ReadLine();
        Console.WriteLine(ConvertHexToBinary(hexNum));
    }

    static string ConvertHexToBinary(string hexNum)
    {
        var hexToBinaryTable = new Dictionary<char, string>
        {
            { '0', "0000"},
            { '1', "0001"},
            { '2', "0010"},
            { '3', "0011"},
            { '4', "0100"},
            { '5', "0101"},
            { '6', "0110"},
            { '7', "0111"},
            { '8', "1000"},
            { '9', "1001"},
            { 'A', "1010"},
            { 'B', "1011"},
            { 'C', "1100"},
            { 'D', "1101"},
            { 'E', "1110"},
            { 'F', "1111"},

        };
        var binaryNum = new StringBuilder();
        for (int i = 0; i < hexNum.Length; i++)
        {
            binaryNum.Append(hexToBinaryTable[hexNum[i]]);
        }

        return binaryNum.ToString().TrimStart('0');
    }

}
