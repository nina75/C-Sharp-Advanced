// Write a method that returns the index of the first element in array
// that is larger than its neighbours, or -1, if there’s no such element.
using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Take(n).Select(x => int.Parse(x)).ToArray();
        Console.WriteLine(FindFirstIndex(numbers));
    }

    static int FindFirstIndex(int[] arr)
    {
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (IsLargerThanNeighbours(arr, i))
            {
                return i;
            }
        }

        return -1;
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
