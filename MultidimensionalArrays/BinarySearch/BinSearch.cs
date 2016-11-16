//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;

class BinSearch
{
    static void Main()
    {
        int[] numbers = { 1, 5, 4, -9, 8, 7, 3, 4, 8, 7, 11, 12, 2 };
        int k = 9;

        Array.Sort(numbers);

        while (Array.BinarySearch(numbers, k) < 0)
        {
            k--;
        }
        Console.WriteLine(k);
        
    }
}
