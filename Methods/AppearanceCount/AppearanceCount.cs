//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
//8
//28 6 21 6 -7856 73 73 -56
//73

using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(FindAppearance(numbers, number));
    }

    static int FindAppearance(int[] arr, int value)
    {
        return arr.Where(x => x == value).ToArray().Length;
    }
}
