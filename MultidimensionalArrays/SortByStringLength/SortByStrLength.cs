//You are given an array of strings. Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] arr = { "Pesho", "Manatarka", "Kon", "Koza" };
        string[] sorted = arr.OrderBy(x => x.Length).ToArray();

        Console.WriteLine(String.Join(", ", sorted));
    }
}
