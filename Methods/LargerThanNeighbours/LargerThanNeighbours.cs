/* Write a method that checks if the element at given position in given array of integers 
   is larger than its two neighbours (when such exist). */
using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Take(n).Select(x => int.Parse(x)).ToArray();
        int count = 0;

        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (IsLargerThanNeighbours(numbers, i)) count++;
        }

        Console.WriteLine(count);
    }

    static bool IsLargerThanNeighbours(int[] arr, int index)
    {
        if (index == 0 || index == arr.Length - 1)
        {
            throw new Exception("The element has not two neighbours");
        }
        if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
        {
            return true;
        }

        return false;
    }
}
