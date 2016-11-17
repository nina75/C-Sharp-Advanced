//Write a method that reverses the digits of given decimal number.

using System;
using System.Collections.Generic;

class ReverseNumber
{
    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine(Reverse(number));
    }

    static decimal Reverse(decimal number)
    {
        string numberAsString = number.ToString();
        char[] arr = numberAsString.ToCharArray();
        Array.Reverse(arr);
        decimal reversed = decimal.Parse(String.Join("", arr));

        return reversed;
    }

}
