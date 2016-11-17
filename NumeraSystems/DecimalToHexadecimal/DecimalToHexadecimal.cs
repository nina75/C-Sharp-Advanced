//Write a program that converts a decimal number N to its hexadecimal representation.
using System;
using System.Text;

class DecimalToHexadecimal
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
       // char[] symbols = { '0', '1' };
        //Console.WriteLine(symbols[0]); 
        Console.WriteLine(ConvertDecimalToHexadecimal(num));

    }

    static string ConvertDecimalToHexadecimal(long number)
    {
        char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        var hexNum = new StringBuilder(); 
        while (number > 0)
        {
            //char remainder = symbols[number % 16];
            hexNum.Insert(0, symbols[number % 16]);
            number /= 16;
        }

        return hexNum.ToString();
    }
}
