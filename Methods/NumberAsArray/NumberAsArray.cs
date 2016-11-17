//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        int[] lengths = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        int n = lengths[0];
        int m = lengths[1];
        var firstArr = new List<int>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Take(n).Select(x => int.Parse(x)).ToArray()); //8 3 3 // 23930
        var secondArr = new List<int>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Take(m).Select(x => int.Parse(x)).ToArray()); //8 3 3 // 23930
        int len = Math.Max(firstArr.Count, secondArr.Count);

        if (firstArr.Count < len)
        {
            for (int i = firstArr.Count; i < len; i++)
            {
                firstArr.Add(0);
            }

        }
        if (secondArr.Count < len)
        {
            for (int i = secondArr.Count; i < len; i++)
            {
                secondArr.Add(0);
            }

        }

        int[] result = new int[len + 1];
        int addition = 0;

        for (int i = 0; i < len; i++)
        {
            int sumOfDigits = firstArr[i] + secondArr[i] + addition;

            if (sumOfDigits > 9)
            {
                sumOfDigits %= 10;
                addition = 1;
            }
            else
            {
                addition = 0;
            }

            result[i] = sumOfDigits;
        }

        var output = new StringBuilder(String.Join(" ", result));
        if (output[output.Length - 1] == '0')
        {
            output.Remove(output.Length - 1, 1);
        }
        Console.WriteLine(output);
    }
}
