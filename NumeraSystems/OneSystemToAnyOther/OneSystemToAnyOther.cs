//Write a program to convert the number N
//from any numeral system of given base s to any other numeral system of base d.

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Text;
class OneSystemToAnyOther
{
    static string ConvertBaseSToBaseD(string numberInBaseS, int baseS, int baseD)
    {
        long decimalNum = 0;
        string numberInBaseD = string.Empty;

        if (baseS < 10)
        {
            decimalNum = ConvertSmallerToDecimal(numberInBaseS, baseS);
        }
        else
        {
            decimalNum = ConvertBiggerToDecimal(numberInBaseS, baseS);
        }

        if (baseD < 10)
        {
            numberInBaseD = ConvertDecimalToSmaller(decimalNum, baseD);
        }
        else
        {
            numberInBaseD = ConvertDecimalToBigger(decimalNum, baseD);
        }
        return numberInBaseD;
    }
    static long ConvertSmallerToDecimal(string number, int base1)
    {
        long decNum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            decNum += (number[i] - '0') * (long)Math.Pow(base1, (number.Length - 1 - i));
        }
        return decNum;
    }
    static long ConvertBiggerToDecimal(string number, int base1)
    {
        char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
        long decNum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            long temp = Array.IndexOf(symbols, number[i]);
            decNum += temp * (long)Math.Pow(base1, number.Length - 1 - i);
        }
        return decNum;
    }
    static string ConvertDecimalToSmaller(long number, int base2)
    {
        string converted = string.Empty;
        while (number > 0)
        {
            converted = number % base2 + converted;
            number /= base2;
        }
        return converted;
    }
    static string ConvertDecimalToBigger(long number, int base2)
    {
        string converted = string.Empty;
        char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f' };
        while (number > 0)
        {
            long temp = number % base2;
            if (temp <= 9)
            {
                converted = temp + converted;
            }
            else
            {
                converted = letters[temp - 10] + converted;
            }
            number /= base2;
        }
        return converted;
    }

    static void Main()
    {
        //Console.Write("S = ");
        int s = int.Parse(Console.ReadLine());

        //Console.Write("Number in base {0}: ", s);
        string number = Console.ReadLine();

        //Console.Write("D = ");
        int d = int.Parse(Console.ReadLine());

        string result = ConvertBaseSToBaseD(number, s, d);
        //Console.WriteLine("Number is base {0, 2}: {1}", d, result);
        Console.WriteLine(result);
    }
}