//Write a method that returns the last digit of given integer as an English word. 
//Write a program that reads a number and prints the result of the method.
using System;

class LastDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigit(number));
    }

    static string GetLastDigit(int number)
    {
        string digit = "";
        switch (number % 10)
        {
            case 0:
                digit = "zero";
                break;
            case 1:
                digit = "one";
                break;
            case 2:
                digit = "two";
                break;
            case 3:
                digit = "three";
                break;
            case 4:
                digit = "four";
                break;
            case 5:
                digit = "five";
                break;
            case 6:
                digit = "six";
                break;
            case 7:
                digit = "seven";
                break;
            case 8:
                digit = "eight";
                break;
            case 9:
                digit = "nine";
                break;
            default:
                break;
        }
        return digit;
    }
}
