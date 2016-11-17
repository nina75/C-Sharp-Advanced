using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(CalcFactorial(n));

    }

    static BigInteger CalcFactorial(int number)
    {
        BigInteger factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

}
