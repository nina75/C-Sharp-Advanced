//Write a program that converts a decimal number N to its hexadecimal representation.
using System;
using System.Text;

class DecimalToHexadecimal
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecimalToHexadecimal(num));

    }

    static string ConvertDecimalToHexadecimal(long number)
    {
        
        var hexNum = new StringBuilder(); 
        while (number > 0)
        {
            hexNum.Insert(0, symbols[number % 16]);
            number /= 16;
        }

        return hexNum.ToString();
    }
}
