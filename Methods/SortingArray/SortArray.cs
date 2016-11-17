//Write a method that returns the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order. 
//Write a program that sorts a given array.

using System;
using System.Linq;

class SortArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        Array.Sort(numbers);
        Console.WriteLine(String.Join(" ", numbers));
    }

    //static void SortArray(int index, int[] arr)
    //{
    //    var segment = new ArraySegment<int>(arr, index, arr.Length - index + 1).ToArray();
    //    Array.Sort(segment);
    //}
}
