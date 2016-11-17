//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//x2 + 5 = 1x2 + 0x + 5 -->  5 0 1

using System;
using System.Linq;

class AddPolynomials
{
    static int[] AddPolynoms(int[] pol1, int[] pol2)
    {
        int[] longer = GetLonger(pol1, pol2);
        int lenDiff = Math.Abs(pol1.Length - pol2.Length);
        int[] result = new int[longer.Length];
        for (int i = 0; i < longer.Length - lenDiff; i++)
        {
            result[i] = pol1[i] + pol2[i];
        }
        for (int i = longer.Length - lenDiff; i < longer.Length; i++)
        {
            result[i] = longer[i];
        }
        return result;
    }

    static int[] GetLonger(int[] arr1, int[] arr2)
    {
        return arr1.Length > arr2.Length ? arr1 : arr2;
    }

    static void PrintPolynom(int[] pol)
    {
        for (int i = pol.Length - 1; i > 0; i--)
        {
            Console.Write("{0}x^{1} + ", pol[i], i);
        }
        Console.Write(pol[0]);
        Console.WriteLine();
    }
    static void Main()
    {
        int len = int.Parse(Console.ReadLine());
        int[] firstPolynom = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Take(len).Select(x => int.Parse(x)).Take(len).ToArray();
        int[] secondPolynom = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Take(len).Select(x => int.Parse(x)).Take(len).ToArray();

        int[] sum = AddPolynoms(firstPolynom, secondPolynom);
        Console.WriteLine(String.Join(" ", sum));
    }
}

